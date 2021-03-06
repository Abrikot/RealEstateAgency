﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateAgency.DataAccess;

namespace RealEstateAgency.ViewModels
{
    public class HomeViewModel : BaseNotifyPropertyChanged
    {
        public HomeViewModel() : this(false) { }
        public HomeViewModel(bool synchronizeWithContext = false) : base(synchronizeWithContext) { }

        public int? EstatesCount
        {
            get
            {
                return (int?)GetProperty();
            }
            set
            {
                SetProperty(value);
            }
        }
        public int? EstatesOnSellCount
        {
            get
            {
                return (int?)GetProperty();
            }
            set
            {
                SetProperty(value);
            }
        }

        public async Task InitializeData()
        {
            Connection dbConn = await Connection.GetCurrentAsync();
            EstatesCount = await dbConn.SelectCountAsync<Model.Estate>();
            Tools.Notifications.ShowErrors(dbConn.Errors);
            EstatesOnSellCount = await dbConn.SelectCountAsync<Model.Transaction>((t) => !t.Transaction_done && t.Type == Model.Transaction.Sale_or_Rent.Sale);
            Tools.Notifications.ShowErrors(dbConn.Errors);
        }


        public Commands.Command New
        {
            get
            {
                return new Commands.Command(async () =>
                {
                    Views.AddEditWindow w = new Views.AddEditWindow();
                    w.DataContext = new AddEditModel();
                    w.Show();
                });
            }
        }

        public Commands.Command ViewEstatesList
        {
            get
            {
                return new Commands.Command(async () =>
                {
                    Views.ChoixBien w = new Views.ChoixBien();
                    w.DataContext = new EstatesListViewModel();
                    w.Show();
                });
            }
        }
    }
}
