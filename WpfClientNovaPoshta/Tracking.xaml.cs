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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create("http://api.novaposhta.ua/v2.0/json/");
            client.Method = "POST";
            client.ContentType = "application/json";
            string api = "fa65506491a98ed202663e43d0144f3b";
            var streamOut = new StreamWriter(client.GetRequestStream());
            string json2 = "{\"apiKey\":" + $"\" {api}" + "\",\"modelName\":\"TrackingDocument\",\"calledMethod\":\"getStatusDocuments\",\"methodProperties\":{\"Documents\":[{\"DocumentNumber\":" + $"\"{txt1.Text}\"" + ",\"Phone\":" + $"\"{txt2.Text}" + "\"}]}}";
            streamOut.Write(json2);
            streamOut.Close();
            var responce = client.GetResponse();
            var stream = new StreamReader(responce.GetResponseStream());
            var text = stream.ReadToEnd();
            RootObject datum = JsonConvert.DeserializeObject<RootObject>(text);
            lbl1.Content = datum.data[0].CitySender;
            lbl2.Content = datum.data[0].CityRecipient;
            if (datum.data[0].StatusCode == "7" || datum.data[0].StatusCode == "8")
            {
                bar1.Value = 100;
                bar2.Value = 100;
                bar3.Value = 100;
                bar4.Value = 0;
                lbl3.Content = "Прибув у відділення";
            }
            if (datum.data[0].StatusCode == "1")
            {
                bar1.Value = 1;
                bar2.Value = 0;
                bar3.Value = 0;
                bar4.Value = 0;
                lbl3.Content = "Нова пошта очікує надходження від відправника";
            }
            if (datum.data[0].StatusCode == "5")
            {
                bar1.Value = 100;
                bar2.Value = 100;
                bar3.Value = 0;
                bar4.Value = 0;
                lbl3.Content = $"Відправлення прямує до {datum.data[0].CityRecipient}";
            }
            if (datum.data[0].StatusCode == "9")
            {
                bar1.Value = 100;
                bar2.Value = 100;
                bar3.Value = 100;
                bar4.Value = 100;
                lbl3.Content = $"Відправлення отримано";
            }
            if (datum.data[0].StatusCode == "101")
            {
                bar1.Value = 100;
                bar2.Value = 100;
                bar3.Value = 0;
                bar4.Value = 0;
                lbl3.Content = $"Відправлення отримано";

            }
        }

    }
}
