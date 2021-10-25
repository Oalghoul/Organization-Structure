using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrganizationStructureService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // MessageBox.Show("Hello MessageBox");

           
        }

        private void NavigateTo_Roles(object sender, RoutedEventArgs e)
        {


            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Views/ManageRolesView.xaml", UriKind.Relative);
            window.Show();
            //this.Visibility = Visibility.Hidden;

        }

        private void NavigateTo_Persons(object sender, RoutedEventArgs e)
        {

            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Views/ManagePersonsView.xaml", UriKind.Relative);
            window.Show();
            //this.Visibility = Visibility.Hidden;


        }

        //this.NavigationService.Navigate(new Uri("Pages/Page2.xaml", UriKind.Relative));

        /*
       var ns = NavigationService;
        ns.Navigate(new Uri("Views/ManageRolesView.xaml", UriKind.Relative));
        */


        /*
         
         NAV1
        NavigationWindow navWIN = new NavigationWindow();
        navWIN.Content = new OrganizationStructureService.Views.ManageRolesView();
        navWIN.Show();
        
         
         NAV2
            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("Views/ManageRolesView.xaml", UriKind.Relative);
            window.Show();
            this.Visibility = Visibility.Hidden;
         */


    }
}
