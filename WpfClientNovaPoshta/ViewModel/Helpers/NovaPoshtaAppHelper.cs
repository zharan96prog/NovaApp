using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpfClientNovaPoshta.Model;

namespace WpfClientNovaPoshta.ViewModel.Helpers
{
    public class NovaPoshtaAppHelper
    {
        public static async Task<List<DatumCity>> GetCities(string query)
        {
            List<RootobjectCity> cities = new List<RootobjectCity>();
            HttpWebRequest client = (HttpWebRequest)WebRequest.Create("http://api.novaposhta.ua/v2.0/json/");
            client.ContentType = "application/json";
            client.Method = "POST";
            var streamOut = new StreamWriter(client.GetRequestStream());
            string api = "fa65506491a98ed202663e43d0144f3b";
            string json = "{\"apiKey\":" + $"\" {api}" + "\", \"modelName\": \"Address\", \"calledMethod\": \"searchSettlements\",\"methodProperties\": {\"CityName\": " + $"\" {query}" + "\", \"Limit\": 10 }}";
            streamOut.Write(json);
            streamOut.Close();
            var responce = await client.GetResponseAsync();
            var stream = new StreamReader(responce.GetResponseStream());
            var text = await stream.ReadToEndAsync();
            var t1 = JsonConvert.DeserializeObject<RootobjectCity>(text);
            return t1.data.ToList();
        }
    }
}
