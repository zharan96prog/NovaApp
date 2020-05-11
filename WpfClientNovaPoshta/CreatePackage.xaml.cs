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
using System.Windows.Shapes;
using WCF_Lib;
using WpfClientNovaPoshta.ServiceReferencePoshta;

namespace WpfClientNovaPoshta
{
    public partial class CreatePackage : Window
    {
        public NovaPoshtaClient proxy = new NovaPoshtaClient();
        public CreatePackage()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if(rb1.IsChecked==true)
            {
                Package package = new Package()
                {
                    NameDest = txtFIO.Text,
                    City = txtCity.Text,
                    Department = depart.Text,
                    Remittance = Convert.ToInt32(nalogka.Text),
                    Payer = 0,
                    ID_User = 1,
                    Description = descrip.Text
                };
                await proxy.CreatePackageAsync(package);
            }
            if (rb2.IsChecked == true)
            {
                Package package = new Package()
                {
                    NameDest = txtFIO.Text,
                    City = txtCity.Text,
                    Department = depart.Text,
                    Remittance = Convert.ToInt32(nalogka.Text),
                    Payer = 1,
                    ID_User = 1,
                    Description = descrip.Text
                };
                await proxy.CreatePackageAsync(package);
            }
            this.Close();

        }
    }
}
