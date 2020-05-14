using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClientNovaPoshta.Model
{

    public class RootobjectCost
    {
        public bool success { get; set; }
        public DatumCost[] data { get; set; }
        public object[] errors { get; set; }
        public string[] warnings { get; set; }
        public object[] info { get; set; }
        public object[] messageCodes { get; set; }
        public object[] errorCodes { get; set; }
        public string[] warningCodes { get; set; }
        public object[] infoCodes { get; set; }
    }

    public class DatumCost
    {
        public int AssessedCost { get; set; }
        public int Cost { get; set; }
        public int CostRedelivery { get; set; }
        public Tzoneinfo TZoneInfo { get; set; }
        public int CostPack { get; set; }
    }

    public class Tzoneinfo
    {
        public string TzoneName { get; set; }
        public string TzoneID { get; set; }
    }

}
