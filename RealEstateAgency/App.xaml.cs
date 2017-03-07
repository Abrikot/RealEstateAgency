using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RealEstateAgency
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            DataAccess.Connection dbConn;
            dbConn = await DataAccess.Connection.GetCurrentAsync();
            if (Tools.Notifications.ShowErrors(dbConn.Errors))
            {
                Application.Current.Shutdown();
                return;
            }
            await dbConn.InitializeDatabaseAsync();
            if (Tools.Notifications.ShowErrors(dbConn.Errors))
            {
                Application.Current.Shutdown();
                return;
            }
        }
    }
}
