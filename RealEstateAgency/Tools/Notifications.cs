using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RealEstateAgency.Tools
{
    public static class Notifications
    {
        public static bool ShowErrors(List<string> errors)
        {
            if (errors.Count  == 0)
            {
                return false;
            }

            string message = "";
            foreach(string error in errors)
            {
                if (!string.IsNullOrEmpty(message)) message += "\n\r";
                message += error;
            }

            MessageBox.Show(message, "Erreurs", MessageBoxButton.OK, MessageBoxImage.Error);
            return true;
        }
    }
}
