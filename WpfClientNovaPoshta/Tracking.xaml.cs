using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create("http://api.novaposhta.ua/v2.0/json/");
            {
                client.Method = "POST";
                client.ContentType = "application/json";

                var streamOut = new StreamWriter(client.GetRequestStream());
                string api = "fa65506491a98ed202663e43d0144f3b";
                string json = String.Format("{\"apiKey\":\"{0}\",\"modelName\":\"TrackingDocument\",\"calledMethod\":\"getStatusDocuments\",\"methodProperties\":{\"Documents\":[{\"DocumentNumber\":\"20450234771943\",\"Phone\":\"0954165091\"}]}}", api);
                streamOut.Write(json);
                streamOut.Close();
                var responce = client.GetResponse();
                var stream = new StreamReader(responce.GetResponseStream());
                var text = stream.ReadToEnd();
                lbl.Content = text;

              //  string json = await response.Content.ReadAsStringAsync();
              //  list = JsonConvert.DeserializeObject<List<Datum>>(json);
            }
            return list;
        }
    }
}
