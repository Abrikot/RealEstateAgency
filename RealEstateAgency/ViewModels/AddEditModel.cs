using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAgency.DataAccess;
using RealEstateAgency.Model;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Media.Imaging;


namespace RealEstateAgency.ViewModels
{
    public class AddEditModel : BaseNotifyPropertyChanged
    {
        private Estate _estate;
        public Estate EstateProperty
        {
            get
            {
                return _estate;
            }

            set
            {
                _estate = value;
            }
        }
        private Photo _photo;
        public Photo PhotoProperty
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
            }
        }
        private string _imagePath;
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                _imagePath = value;
            }
        }

        public AddEditModel() : this(null, false) { }
        public AddEditModel(Estate estate = null, bool synchronizeWithContext = false) : base(synchronizeWithContext)
        {
            if ((_estate = estate) == null)
            {
                // Création de l'estate par défaut
                _estate = new Estate();
                _estate.Address = "Adresse par défaut";
                _estate.AnnualCharges = 0;
                _estate.City = "Ville par défaut";
                _estate.CommercialId = 0;
                _estate.Elevator = false;
                _estate.EstateType = Estate.Type.House;
                _estate.EstimatedPrice = 0;
                _estate.FloorCount = 1;
                _estate.FloorNumber = 0;
                _estate.PropertyTaxes = 0;
                _estate.RoomsCount = 1;
                _estate.Surface = 0;
                _estate.SurfaceCarrez = 0;
                _estate.Zip = 01000;

                // Création de l'objet Photo
                _photo = new Photo();

                ImagePath = "Salut";
            }
        }

        public Commands.Command<Views.AddEditWindow> Cancel
        {
            get
            {
                return new Commands.Command<Views.AddEditWindow>(async (Views.AddEditWindow window) =>
                {
                    window.Close();
                });
            }
        }
        public Commands.Command<Views.AddEditWindow> Valid
        {
            get
            {
                return new Commands.Command<Views.AddEditWindow>(async (Views.AddEditWindow window) =>
                {
                    // Ajout de l'estate à la BD
                    Connection dbConn = await Connection.GetCurrentAsync();
                    await dbConn.InsertAsync<Estate>(_estate);
                    Tools.Notifications.ShowErrors(dbConn.Errors);

                    // Récupération de l'ID de l'estate
                    EstateProperty.Id = (int)(await dbConn.SelectLastInsertedAutoKeyAsync<Estate>());

                    // Création puis ajout de l'image à la BD
                    PhotoProperty.Base64 = Converters.Base64StringToBitmapImageConverter.BitmapImageToBase64String(new BitmapImage(new Uri(ImagePath)));
                    PhotoProperty.Title = "Photo principale";
                    PhotoProperty.ShootingDate = DateTime.Now;
                    PhotoProperty.EstateId = EstateProperty.Id;

                    await dbConn.InsertAsync<Photo>(PhotoProperty);
                    Tools.Notifications.ShowErrors(dbConn.Errors);

                    // Récupération de l'ID de la photo
                    PhotoProperty.Id = (int)(await dbConn.SelectLastInsertedAutoKeyAsync<Photo>());

                    // Modificaiton de l'estate et mise à jour dans la BD
                    EstateProperty.MainPhotoId = PhotoProperty.Id;
                    await dbConn.UpdateAsync<Estate>(EstateProperty);
                    Tools.Notifications.ShowErrors(dbConn.Errors);

                    // Fermeture de la fenêtre
                    window.Close();
                });
            }
        }
        public Commands.Command ChooseImage
        {
            get
            {
                return new Commands.Command(async () =>
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.Filter = "Fichier image|*.jpg;*.png;*.jpeg";
                    bool? result = file.ShowDialog();
                    if (result == true)
                    {
                        ImagePath = file.FileName;
                    }
                });
            }
        }
    }
}
