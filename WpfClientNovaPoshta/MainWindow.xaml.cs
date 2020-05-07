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
        public NovaPoshtaClient proxy = new NovaPoshtaClient();
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            CreatePackage createPackage = new CreatePackage();
            createPackage.Show();

            //await proxy.CreatePackageAsync(new Package {Number="2222", City="Rivne", Department="3", Description="PC",
            //    NameDest ="SanyaD", Payer=0, Remittance=1010, ID_User=1});
        }
    }
}
