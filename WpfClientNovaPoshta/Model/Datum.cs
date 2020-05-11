using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClientNovaPoshta.Model
{
    public class Datum
    {
        public string Number { get; set; }
        public string RefCitySender { get; set; }
        public string RefCityRecipient { get; set; }
        public string CardMaskedNumber { get; set; }
        public string BarcodeRedBox { get; set; }
        public IList<object> Packaging { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public string RefEW { get; set; }
        public string RecipientFullName { get; set; }
        public string CargoDescriptionString { get; set; }
        public string RedeliverySum { get; set; }
        public string RedeliveryPayer { get; set; }
        public string AfterpaymentOnGoodsCost { get; set; }
        public string LastCreatedOnTheBasisPayerType { get; set; }
        public string LastTransactionDateTimeGM { get; set; }
        public string CounterpartySenderDescription { get; set; }
        public string CounterpartyRecipientDescription { get; set; }
        public string SenderAddress { get; set; }
        public string RecipientAddress { get; set; }
        public string AnnouncedPrice { get; set; }
        public string RedeliveryPaymentCardRef { get; set; }
        public string RedeliveryPaymentCardDescription { get; set; }
        public string CreatedOnTheBasis { get; set; }
        public string DatePayedKeeping { get; set; }
        public string OnlineCreditStatusCode { get; set; }
        public string OnlineCreditStatus { get; set; }
    }

    public class Warning
    {
        public string ID_20400048799000 { get; set; }
        public string ID_20400048799001 { get; set; }
    }

    public class Package
    {
        public bool success { get; set; }
        public IList<Datum> data { get; set; }
        public IList<object> errors { get; set; }
        public IList<Warning> warnings { get; set; }
        public IList<object> info { get; set; }
        public IList<object> messageCodes { get; set; }
        public IList<object> errorCodes { get; set; }
        public IList<object> warningCodes { get; set; }
        public IList<object> infoCodes { get; set; }
    }

}
