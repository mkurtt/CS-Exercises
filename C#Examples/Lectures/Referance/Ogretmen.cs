using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ogretmen
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TelNo { get; set; }

        public Okul Okul { get; set; }

        public Ogrenci[] Ogrenciler { get; set; }

    }
}
