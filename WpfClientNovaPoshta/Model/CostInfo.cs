using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClientNovaPoshta.Model
{
    public class DatumCost
    {
        public int CostRedelivery { get; set; }
        public int AssessedCost { get; set; }
        public int Cost { get; set; }
        public int CostPack { get; set; }
    }

    public class CostInfo
    {
        public bool success { get; set; }
        public IList<Datum> data { get; set; }
        public IList<object> errors { get; set; }
        public IList<string> warnings { get; set; }
        public IList<object> info { get; set; }
        public IList<object> messageCodes { get; set; }
        public IList<object> errorCodes { get; set; }
        public IList<string> warningCodes { get; set; }
        public IList<object> infoCodes { get; set; }
    }

}
