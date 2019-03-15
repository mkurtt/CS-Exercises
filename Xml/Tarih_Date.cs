using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGK.Basecore.Xml.Data
{

    // where to put this ?
    public class Tarih_Date
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Currency")]
        public Tarih_DateCurrency[] Currency { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tarih { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Bulten_No { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Tarih_DateCurrency
    {

        /// <remarks/>
        public byte Unit { get; set; }

        /// <remarks/>
        public string Isim { get; set; }

        /// <remarks/>
        public string CurrencyName { get; set; }

        /// <remarks/>
        public decimal ForexBuying { get; set; }

        /// <remarks/>
        public string ForexSelling { get; set; }

        /// <remarks/>
        public string BanknoteBuying { get; set; }

        /// <remarks/>
        public string BanknoteSelling { get; set; }

        /// <remarks/>
        public string CrossRateUSD { get; set; }

        /// <remarks/>
        public string CrossRateOther { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CrossOrder { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode { get; set; }
    }
}
