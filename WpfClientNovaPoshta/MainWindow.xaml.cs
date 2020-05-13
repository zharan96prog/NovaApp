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
using WpfClientNovaPoshta.ServiceReferencePoshta;

namespace WpfClientNovaPoshta
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            CreatePackage createPackage = new CreatePackage();
            createPackage.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tracking trackingWindow = new Tracking();
            trackingWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DateOfDelivery delivery = new DateOfDelivery();
            delivery.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CostInfo cost = new CostInfo();
            cost.Show();
        }
    }
}
