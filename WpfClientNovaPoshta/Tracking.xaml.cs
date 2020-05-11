using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using WpfClientNovaPoshta.Model;

namespace WpfClientNovaPoshta
{
    /// <summary>
    /// Логика взаимодействия для Tracking.xaml
    /// </summary>
    public partial class Tracking : Window
    {
        public Tracking()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GetAllDatum();
        }

        private async Task<List<Datum>> GetAllDatum()
        {
            List<Datum> list = new List<Datum>();
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://testapi.novaposhta.ua/v2.0/en/documentsTracking/json/");
                string json = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<Datum>>(json);
            }
            return list;
        }
    }
}
