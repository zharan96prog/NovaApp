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

namespace WpfClientNovaPoshta
{
    public partial class LoginWindow : Window
    {
        ContextLogin context = new ContextLogin();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var temp = (from i in context.User
                       where i.Phone.Equals(phoneLogin.Text)
                       select i).First();
            if(temp == null)
                MessageBox.Show("Вам потрібно зареєструватися", "Увага!", MessageBoxButton.OK, MessageBoxImage.Warning);
            if(temp != null)
            {
                MainWindow window = new MainWindow();
                window.Show();
                this.Close();
            }
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in context.User)
            {
                if (phone.Text == item.Phone)
                {
                    MessageBox.Show("Такий профіль вже існує", "Увага!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                break;
            }
            EntityForLogin.User user = new EntityForLogin.User()
            {
                City = city.Text,
                Name = name.Text,
                Phone = phone.Text,
            };
            context.User.Add(user);
            context.SaveChanges();
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
