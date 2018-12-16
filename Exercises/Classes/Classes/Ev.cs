using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Ev
    {
        public string semt;
        public string mahalle;

        public byte odaSayisi;
        public decimal metrekare;

        public decimal fiyat;

        public string BilgileriGetir()
        {
            return $"Semt:{semt}, Mahalle:{mahalle}, Oda Sayisi:{odaSayisi}, Metrekare:{metrekare}, Fiyat:{fiyat}";
        }


    }
}
