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
using WpfClientNovaPoshta.EntityForLogin;
using WpfClientNovaPoshta.ServiceReferencePoshta;

namespace WpfClientNovaPoshta
{
    public partial class CreatePackage : Window
    {
        public NovaPoshtaClient proxy = new NovaPoshtaClient();
        ContextLogin context = new ContextLogin();
        public CreatePackage()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            int ID_Sender = (from i in context.User
                         where i.Phone.Equals(phone_sender.Text)
                         select i.ID).First();

            if(rb1.IsChecked==true)
            {
                WCF_Lib.Package package = new WCF_Lib.Package()
                {
                    NameDest = txtFIO.Text,
                    City = txtCity.Text,
                    Department = depart.Text,
                    Remittance = Convert.ToInt32(nalogka.Text),
                    Payer = 0,
                    ID_User = ID_Sender,
                    Description = descrip.Text
                };
                await proxy.CreatePackageAsync(package);
            }
            if (rb2.IsChecked == true)
            {
                WCF_Lib.Package package = new WCF_Lib.Package()
                {
                    NameDest = txtFIO.Text,
                    City = txtCity.Text,
                    Department = depart.Text,
                    Remittance = Convert.ToInt32(nalogka.Text),
                    Payer = 1,
                    ID_User = ID_Sender,
                    Description = descrip.Text
                };
                await proxy.CreatePackageAsync(package);
            }
            this.Close();

        }
    }
}
