using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfClientNovaPoshta
{
    /// <summary>
    /// Interaction logic for DateOfDelivery.xaml
    /// </summary>
    public partial class DateOfDelivery : Window
    {
        public DateOfDelivery()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create("http://api.novaposhta.ua/v2.0/json/");
            {
                client.Method = "POST";
                client.ContentType = "application/json";
                var streamOut = new StreamWriter(client.GetRequestStream());
                string api = "fa65506491a98ed202663e43d0144f3b";
                var citySender = 0;
                var cityRecipient = 0;
                string json = "{\"apiKey\":" + $"\" {api}" + "\",\"modelName\": \"InternetDocument\",\"calledMethod\": \"getDocumentDeliveryDate\",\"methodProperties\": {\"DateTime\":" + $"\" {DatePicker1.SelectedDate.Value.Day + "." + DatePicker1.SelectedDate.Value.Month + "." + DatePicker1.SelectedDate.Value.Year}" + "\",\"ServiceType\": \"WarehouseDoors\", \"CitySender\": " + $"\" {citySender}" + "\", \"CityRecipient\":" + $"\" {cityRecipient}" + "\"}}";
                streamOut.Write(json);
                streamOut.Close();
                var responce = client.GetResponse();
                var stream = new StreamReader(responce.GetResponseStream());
                var text = stream.ReadToEnd();
               
            }
        }
    }
}
