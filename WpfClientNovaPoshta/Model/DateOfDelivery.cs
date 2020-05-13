using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClientNovaPoshta.Model
{
    public class Rootobject
    {
        public bool success { get; set; }
        public DatumDelivery[] data { get; set; }
        public object[] errors { get; set; }
        public object[] warnings { get; set; }
        public object[] info { get; set; }
        public object[] messageCodes { get; set; }
        public object[] errorCodes { get; set; }
        public object[] warningCodes { get; set; }
        public object[] infoCodes { get; set; }
    }
    public class DatumDelivery
    {
        public Deliverydate DeliveryDate { get; set; }
    }
    public class Deliverydate
    {
        public string date { get; set; }
        public int timezone_type { get; set; }
        public string timezone { get; set; }
    }

}
