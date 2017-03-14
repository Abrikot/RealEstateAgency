using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAgency.DataAccess;
using RealEstateAgency.Model;
using System.Diagnostics;

namespace RealEstateAgency.ViewModels
{
    public class AddEditModel : BaseNotifyPropertyChanged
    {
        private Estate _estate;
        public Estate Estate
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

        public AddEditModel() : this(null, false) { }
        public AddEditModel(Estate estate = null, bool synchronizeWithContext = false) : base(synchronizeWithContext)
        {
            if ((_estate = estate) == null)
            {
                _estate = new Estate();
            }
            //_estate.Address = PCLStorage.FileSystem.Current.LocalStorage.Path;
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
                    Connection dbConn = await Connection.GetCurrentAsync();
                    await dbConn.InsertOrReplaceAsync<Estate>(_estate);
                    Tools.Notifications.ShowErrors(dbConn.Errors);
                    window.Close();
                });
            }
        }
    }
}
