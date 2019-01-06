using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ogrenci
    {
        // get set olmadan public degisken kullanilmis olmasi ve isin get ve set method u gerektirmesi durumunda, ( public string ad; )
        // field in tanimlandigi butun satirlari degistirmek yerine
        // yenilen olusturulan ( private string ISIM; )
        // ile field a eklenen get ve set bagdastirilir.
        // Extra methodlara ihtiyac duymaz.

        private string ISIM;

        public string ad
        {
            get
            {
                return ISIM;
            }
            set
            {
                this.ISIM = value;
            }
        }


        //propfull
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //refactoring
        public string TCNO1
        {
            get
            {
                return TCNO1;
            }
            set
            {
                TCNO1 = value;
            }
        }




        private int yas;

        public void SetYas(int yas)
        {
            if (yas<18)
            {
                yas = 18;
            }
            else
            {
                this.yas = yas;
            }
        }

        public int GetYas()
        {
            return this.yas;
        }
    }
}
