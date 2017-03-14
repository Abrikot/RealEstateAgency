using System.Windows;

namespace RealEstateAgency
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await ((ViewModels.HomeViewModel)DataContext).InitializeData();
        }
    }
}
