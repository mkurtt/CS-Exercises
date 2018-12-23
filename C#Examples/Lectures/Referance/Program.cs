using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen veli = new Ogretmen();
            veli.Okul = new Okul();
            veli.Okul.Ad = "Ataturk Lisesi";

            veli.Ogrenciler = new Ogrenci[5];
            veli.Ogrenciler[0] = new Ogrenci();
            veli.Ogrenciler[0].Ad = "asd";
        }
    }
}
