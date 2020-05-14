using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClientNovaPoshta.Model
{

    public class RootobjectCity
    {
        public bool success { get; set; }
        public DatumCity[] data { get; set; }
        public object[] errors { get; set; }
        public object[] warnings { get; set; }
        public object[] info { get; set; }
        public object[] messageCodes { get; set; }
        public object[] errorCodes { get; set; }
        public object[] warningCodes { get; set; }
        public object[] infoCodes { get; set; }
        
    }

    public class DatumCity
    {
        public int TotalCount { get; set; }
        public Address[] Addresses { get; set; }
    }

    public class Address
    {
        public string Present { get; set; }
        public int Warehouses { get; set; }
        public string MainDescription { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public string SettlementTypeCode { get; set; }
        public string Ref { get; set; }
        public string DeliveryCity { get; set; }
        public bool AddressDeliveryAllowed { get; set; }
        public bool StreetsAvailability { get; set; }
        public string ParentRegionTypes { get; set; }
        public string ParentRegionCode { get; set; }
        public string RegionTypes { get; set; }
        public string RegionTypesCode { get; set; }
    }
    

}
