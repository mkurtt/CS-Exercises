using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        #region Functions
        #region Resizing Array
        static string[] AddOgrenci(string[] ogrenci, string ad, string soyad)
        {


            string[] qwe = new string[ogrenci.Length];
            for (int j = 0; j < ogrenci.Length; j++)
            {
                qwe[j] = ogrenci[j];
            }

            ogrenci = new string[qwe.Length + 1];       // gecici dizi ile takas yaparak genisletme
            for (int j = 0; j < qwe.Length; j++)
            {
                ogrenci[j] = qwe[j];
            }
            ogrenci[ogrenci.Length - 1] = ad + " " + soyad;
            Console.WriteLine("Ogrenci eklendi.");

            return ogrenci;
        }

        static void ListOgrenci(string[] ogrenci)
        {
            for (int j = 0; j < ogrenci.Length; j++)
            {
                Console.WriteLine(ogrenci[j]);
            }
        }

        static void OgrenciAra(string[] ogrenci, string qwer)
        {
            bool Y = false;
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (ogrenci[i].Contains(qwer))
                {
                    Console.Write(ogrenci[i] + "\n");
                    Y = true;
                }
            }
            if (Y == false)
            {
                Console.WriteLine("Bulunamadi.");
            }

        }

        static string[] OgrenciSil(string[] ogrenci, string asdf)
        {
            int indisI = 0;
            int Z = 0;
            for (int i = 0; i < ogrenci.Length; i++)
            {
                if (ogrenci[i].Contains(asdf))
                {
                    Console.WriteLine(ogrenci[i]);                  // gecici dizi ile takas yaparak kucultme
                    Z++;
                    indisI = i;
                }
            }
            if (Z > 1)
            {
                Console.WriteLine("daha kesin bir giris yapiniz");
                return ogrenci;
            }
            else if (Z == 1)
            {
                string[] fdgh = new string[ogrenci.Length - 1];
                for (int j = 0, k = 0; j < ogrenci.Length; j++, k++)
                {
                    if (j == indisI)
                    {
                        k--;
                        continue;
                    }
                    else
                    {
                        fdgh[k] = ogrenci[j];
                    }
                }
                ogrenci = fdgh;
                Console.WriteLine("silindi.");
                return ogrenci;
            }
            else Console.WriteLine("Ogrenci bulunamadi.");
            return ogrenci;
        }

        private static void HelpExResize()
        {
            Console.WriteLine("!!Help-ExResize!!");
            Console.WriteLine("\"ekle\" \tGiris, ex. ekle [isim] [soyisim]");
            Console.WriteLine("\"listele\" \tOgrencileri listeler");
            Console.WriteLine("\"ara\" \tOgrencilerde ara, ex. ara [isim]");
            Console.WriteLine("\"sil\" \tOgrencilerden sil, ex. sil [isim]");
            Console.WriteLine("\"help-exr\" \tBu mesaji hosterir");
            Console.WriteLine("\"exit\" \tCikis");
        }

        static void ResizingArray(byte c)
        {
            string[] ogrenci = new string[0];
            bool X = false;
            Console.WriteLine("!! OGRENCI ORNEK !!");
            if (c == 1) Console.WriteLine("Komutlar icin \"help-exr\" yaziniz.");

            do
            {
                string[] parameters;
                string q = "";
                if (c == 1)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("@" + Kullanici + " >>");
                    Console.ResetColor();
                    string komut = Console.ReadLine();
                    parameters = komut.Split(' ');
                    q = parameters[0];
                }
                else
                {
                    Console.WriteLine("MENU \n1-Ogrenci Ekle\n2-Listele\n3-ogrenci ara\n4-ogrenci sil\n5-Cikis");
                    Console.Write(">>");
                    q = Console.ReadLine();
                    parameters = new string[3];
                }

                switch (q)
                {
                    case "1":
                        Console.Write("ogrenci adi: ");
                        string ad = Console.ReadLine();
                        Console.Write("ogrenci soyadi: ");
                        string soyad = Console.ReadLine();
                        ogrenci = AddOgrenci(ogrenci, ad, soyad);
                        Console.ReadKey();
                        break;

                    case "ekle":

                        if (parameters.Length != 3)
                        {
                            Console.WriteLine("Eksik yada fazla parametre girildi. \"help-exr\" yazarak dogru formati gorebilirsiniz.");
                        }
                        else
                            ogrenci = AddOgrenci(ogrenci, parameters[1], parameters[2]);
                        break;

                    case "2":
                        ListOgrenci(ogrenci);
                        Console.ReadKey();
                        break;
                    case "listele":
                        ListOgrenci(ogrenci);
                        break;
                    case "3":
                        Console.WriteLine("Ara: ");
                        string qwer = Console.ReadLine();
                        OgrenciAra(ogrenci, qwer);
                        Console.ReadKey();
                        break;
                    case "ara":
                        string zxcv = "";

                        if (parameters.Length == 3)
                            zxcv = parameters[1] + " " + parameters[2];
                        else if (parameters.Length == 2)
                        {
                            zxcv = parameters[1];
                            OgrenciAra(ogrenci, zxcv);
                        }
                        break;
                    case "4":
                        Console.Write("Sil: ");
                        string asdf = Console.ReadLine();
                        ogrenci = OgrenciSil(ogrenci, asdf);
                        Console.ReadKey();
                        break;
                    case "sil":
                        string sdfg = "";
                        if (parameters.Length == 3)
                            sdfg = parameters[1] + " " + parameters[2];
                        else if (parameters.Length == 2)
                        {
                            sdfg = parameters[1];
                            ogrenci = OgrenciSil(ogrenci, sdfg);
                        }
                        break;
                    case "help-exr":
                        HelpExResize();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        return;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("yanlis giris");
                        break;
                }

            } while (X == false);

        }

        #endregion

        #region Fibonacci

        static void Fibonacci(int n)
        {
            int first = 0, second = 1, next, c;

            for (c = 0; c < n; c++)
            {
                if (c <= 1)
                    next = c;
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.Write(next + " ");
            }
            Console.WriteLine();
        }






        #endregion

        #region Faktorial

        private static int facq(int v)
        {
            int a = 1;
            for (int i = 1; i <= v; i++)
            {
                a *= i;
            }
            return a;
        }

        //overload
        private static decimal facq(decimal v)
        {
            int a = 1;
            for (int i = 1; i <= v; i++)
            {
                a *= i;
            }
            return a;
        }

        #endregion

        #region galeri

        static void matrixArac() //Hazir elimde bulunan kodu degistirmekle ugrasmak istemedim. bu yuzden komut secenegi yok.
        {
            int Butce = 0;
            const byte garajBoyutu = 100;
            byte currentCarIndex = 0;
            string[,] araclar = new string[garajBoyutu, 4];
            // marka model fiyat kira
            bool X = false;

            araclar[currentCarIndex, 0] = "BMW";      // eklemekle ugrasmamak icin static giris
            araclar[currentCarIndex, 1] = "qwe";
            araclar[currentCarIndex, 2] = "321";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            araclar[currentCarIndex, 0] = "BMW";
            araclar[currentCarIndex, 1] = "asd";
            araclar[currentCarIndex, 2] = "234";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            araclar[currentCarIndex, 0] = "BMW";
            araclar[currentCarIndex, 1] = "zxc";
            araclar[currentCarIndex, 2] = "345";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            araclar[currentCarIndex, 0] = "Opel";
            araclar[currentCarIndex, 1] = "qwe";
            araclar[currentCarIndex, 2] = "321";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            araclar[currentCarIndex, 0] = "Opel";
            araclar[currentCarIndex, 1] = "asd";
            araclar[currentCarIndex, 2] = "345";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            araclar[currentCarIndex, 0] = "Opel";
            araclar[currentCarIndex, 1] = "zxc";
            araclar[currentCarIndex, 2] = "234";
            araclar[currentCarIndex, 3] = "false";
            currentCarIndex++;
            while (true)
            {

                Console.WriteLine($"MENU\n1-Arac Ekle\n2-Kiradan al\n3-Kirala\n4-Cikis\n Bonus: Butce = {Butce}");
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case '1':
                        Console.WriteLine("Arac Markasi: ");
                        araclar[currentCarIndex, 0] = Console.ReadLine();
                        Console.WriteLine("Arac Modeli: ");
                        araclar[currentCarIndex, 1] = Console.ReadLine();
                        Console.WriteLine("Arac Kira Bedeli: ");
                        araclar[currentCarIndex, 2] = Console.ReadLine();
                        araclar[currentCarIndex, 3] = "false";

                        Console.WriteLine("Arac Eklendi!");
                        currentCarIndex++;
                        break;
                    case '2':
                        Console.Clear();
                        Console.Write("KIRALANMIS ARA\nArama Kelimesi: ");
                        string arananKelime = Console.ReadLine();
                        int[] Y = new int[currentCarIndex];
                        int Z = 0;
                        bool V = false;
                        for (int i = 0; i < currentCarIndex; i++)
                        {
                            if ((araclar[i, 0].Contains(arananKelime) || araclar[i, 1].Contains(arananKelime)) && araclar[i, 3].Equals("true"))
                            {
                                Y[i] = Z;
                                Console.WriteLine($"{Z + 1}. Marka: {araclar[i, 0]}, Model: {araclar[i, 1]}, Kira Fiyati: {araclar[i, 2]}");
                                Z++;
                                V = true;
                            }
                            else Y[i] = -1;
                        }
                        if (V == false)
                        {
                            Console.WriteLine("arac yok!");
                            break;
                        }
                        Console.WriteLine("Kacinci Arac Alinacak: ");
                        int zxc = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < currentCarIndex; i++)
                        {
                            if (Y[i] == zxc - 1)
                            {
                                araclar[i, 3] = "false";
                            }
                        }
                        Console.WriteLine("Arac Alindi!");
                        break;
                    case '3':
                        Console.Clear();
                        Console.Write("KIRALANACAK ARA\nArama Kelimesi: ");
                        string arananKelime1 = Console.ReadLine();
                        int[] Y1 = new int[currentCarIndex];
                        int Z1 = 0;
                        bool V1 = false;
                        for (int i = 0; i < currentCarIndex; i++)
                        {
                            if ((araclar[i, 0].Contains(arananKelime1) || araclar[i, 1].Contains(arananKelime1)) && araclar[i, 3].Equals("false"))
                            {
                                Y1[i] = Z1;
                                Console.WriteLine($"{Z1 + 1}. Marka: {araclar[i, 0]}, Model: {araclar[i, 1]}, Kira Fiyati: {araclar[i, 2]}");
                                Z1++;
                                V1 = true;
                            }
                            else Y1[i] = -1;
                        }
                        if (V1 == false)
                        {
                            Console.WriteLine("arac yok!");
                            break;
                        }
                        Console.WriteLine("Kacinci Arac Kiralanacak: ");
                        int zxc1 = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < currentCarIndex; i++)
                        {
                            if (Y1[i] == zxc1 - 1)
                            {
                                araclar[i, 3] = "true";
                                Butce += Convert.ToInt32(araclar[i, 2]);
                            }
                        }



                        Console.WriteLine("Arac Kiralandi!");
                        break;
                    case '4':
                        X = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis tercih.");
                        break;
                }

                if (X == true)
                {
                    break;
                }

                Console.ReadKey();
            }
        }

        #endregion

        #region macSkor

        private static void HelpMac()
        {
            Console.WriteLine("!!Help-MacScore!!");
            Console.WriteLine("\"mac\" \tyeni mac ekler ex. \"mac [takim1] [takim2]\"");
            Console.WriteLine("\"listele\" \tOgrencileri listeler");
            Console.WriteLine("\"help-mac\" \tBu mesaji hosterir");
            Console.WriteLine("\"exit\" \tCikis");
        }

        static void macSkor()
        {
            string[,] Maclar = new string[10, 4];
            int MacIndex = 0;
            Console.WriteLine("\"help-mac\" yazarak baslayiniz.");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@" + Kullanici + " >>");
                Console.ResetColor();
                string strKomut = Console.ReadLine();
                string[] Parameters = strKomut.Split(' ');
                switch (Parameters[0])
                {
                    case "mac":
                        if (Parameters.Length != 3)
                        {
                            Console.WriteLine("Eksik yada fazla parametre girildi. \"help-mac\" yazarak dogru formati gorebilirsiniz.");
                        }
                        else
                        {
                            Random rnd = new Random();
                            Maclar[MacIndex, 0] = Parameters[1];
                            Maclar[MacIndex, 1] = Convert.ToString(rnd.Next(7));
                            Maclar[MacIndex, 2] = Convert.ToString(rnd.Next(7));
                            Maclar[MacIndex, 3] = Parameters[3];

                            Console.WriteLine($"{Maclar[MacIndex, 0]}: {Maclar[MacIndex, 1]} - {Maclar[MacIndex, 2]} :{Maclar[MacIndex, 3]}");
                            MacIndex++;
                        }
                        break;
                    case "listele":
                        for (int i = 0; i < Maclar.GetLength(0); i++)
                        {
                            Console.WriteLine($"{Maclar[i, 0]}: {Maclar[i, 1]} - {Maclar[i, 2]} :{Maclar[i, 3]}");
                        }
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }
            }

        }

        #endregion

        #region jungle

        static bool Key = false;
        static bool Kol = false;
        static Random rnd = new Random();
        static int A = rnd.Next(3);
        static int OdaNo;

        static void BirinciOda()
        {
            OdaNo = 1;
            Console.WriteLine("Uyandigin odaya geri dondun. Etrafta hic bir sey olmadigni biliyorsun. \nHangi kapiya yoneleceksin? (sol-sag)");
        }

        static void SolOda()
        {
            OdaNo = 2;
            if (Key == false)
            {
                Console.WriteLine("Kapiyi acmaaya calistiginda kilitli oldugunu farkettigin kapi bir mekanizmayi tetikledi ve oldun.");
                Gameover();
            }
            else
            {
                Kol = true;
                Console.WriteLine("Guvenli bir sekilde iceri girmeyi basardin. Odaya baktin, bir kol gordun. dier odadaki agir ve metal kapiyi acmak icin olabilecegini dusunerek kolu indiriyorsun. Odada yapacak baska hic bir sey yok. \nGeri donmek icin \"geri\" yaziniz.");
            }
        }

        static void SagOda()
        {
            OdaNo = 3;
            if (Kol == false)
            {
                Key = true;
                Console.WriteLine("Odaya girdin. Karsinda Demir bir kapi duruyor. Uzerinde ufak bir anahtar deligi disinda hic bir sey yok. Odayi aramaya basliyorsun, ve bir anahtar buluyorsun.\nNe Yapacaksin? (geri-kapiyi dene)");
            }
            else
            {
                Console.WriteLine("Odaya girdin. ve dier odada indirdigin kolun kapiyi actigini gordun. ");
                Disarisi();
            }
        }

        static void Disarisi()
        {
            if (A == 1)
            {
                Console.WriteLine("Disariyi gorunce heycanla kosarak ciktin. Binanin disarisindaki silahli insanlarin dikkatini cektin, seni silahla vurarak oldurduler.");
                Gameover();
            }
            else
            {
                Console.WriteLine("Supheli bir sekilde yavasca disari ciktin ve silahli askerleri gordun. onlarin dikkatini cekmemek icin yavas bir sekilde uzaklasarak kurtuldun. \n Oyunu kazandin.\nBaskatan baslamak icin \"restart\", cikmak icin \"exit\"");
            }
        }

        static void kapi()
        {
            Console.WriteLine("Anahtari kapiya soktugun anda yuksek woltajli bir elektrik shocku yedin ve orada o anda oldun.");
            Gameover();
        }

        static void Gameover()
        {
            Console.WriteLine("OYUN BITTI!");
            Console.WriteLine("Yeniden baslamak icin \"restart\" yaz.");
            Console.WriteLine("Cikmak icin \"exit\" yaz.");
        }

        static void Jungle()
        {
            OdaNo = 1;
            Console.WriteLine("Example Jungle Game!");
            Console.WriteLine("\t\t\t Bu oyunda buglarla karsilasmak mumkun. ayni odaya tekrar girip ciktikca olan olaylarin tekrar etmesi gibi. Detayli ugrasmak icin fazla vakit bulamadim.");

            Console.WriteLine("Karanlik bir odada uyandin. Etrafina bakiyorsun, butun oda bombos. farkli yerlere acildigini dusundugum yan yana 2 kapi var. Kapilardan birisine giderek cikis yolu aramaya karar verdin karar verdin. \nHangi Kapidan gececeksin? (sol-sag)");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@" + Kullanici + " >>");
                Console.ResetColor();
                string c = Console.ReadLine();
                switch (c)
                {
                    case "kapiyi dene":
                        if (OdaNo == 3)
                            kapi();
                        break;
                    case "geri":
                        if (OdaNo != 1)
                            BirinciOda();
                        break;
                    case "sol":
                        if (OdaNo == 1)
                            SolOda();
                        break;
                    case "sag":
                        if (OdaNo == 1)
                            SagOda();
                        break;
                    case "restart":
                        Jungle();
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }
            }
        }

        #endregion

        #endregion

        #region kullanimlar

        static void SideMain(/*string[] args*/)
        {

            #region rest
            ////PARAMS

            //MenuOlustur("Menu", "Ekle", "sil", "guncelle", "cikis");

            ////HATA YAKALAMA

            //string secim = Console.ReadLine();
            //int s = 0;

            //bool sonuc = int.TryParse(secim, out s);

            ////bool sonuc = donusturmeyiDene(secim, ref s);


            ////if (sonuc)
            //{
            //    switch (s)
            //    {
            //        case 1:
            //            break;
            //        case 2:
            //            break;
            //        case 3:
            //            break;
            //        case 4:
            //            return;
            //        default:
            //            Console.WriteLine("Yanlis secim yapildi");
            //            break;
            //    }

            ////OUT & REF
            //int s = 10;
            //int yeniDeger = SayiEkleREF(ref s);

            //int s1;
            //int yeniDeger1 = SayiEkleOUT(out s1);
            //Console.WriteLine(s);
            //Console.WriteLine(yeniDeger);

            ////RECURSIVE
            //RecursiveMethod(0);

            ////DEFAULT PARAMETER
            //bool a = Palindrom(); // cumle = Vektorel
            //a = Palindrom("Ankara"); // cumle = Ankara

            #endregion

        }


        #region default param
        //Default parametre tanimlama
        static bool Palindrom(string cumle = "Vektorel")
        {
            int count = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if (cumle[i] == cumle[cumle.Length - i - 1])
                {
                    count++;
                }
            }
            return count == cumle.Length;
        }

        #endregion

        #region recursive Example
        static void RecursiveMethod(int a)
        {
            if (a < 10)
            {
                a++;
                Console.WriteLine("recursive method");
                RecursiveMethod(a);
                Console.WriteLine("recursive method cikis");
            }
        }

        #endregion

        #region params

        // params hep en sagda
        static void MenuOlustur(string MenuBaslik, params string[] dizi)
        {
            Console.WriteLine(MenuBaslik);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{dizi[i]}");
            }
        }
        #endregion

        #region out & ref

        //out ve ref parametre kullanimi
        //ref > sayi yi  s nin degerinden  s ninn rreferansi haline getirir. ref te tanimlandigi yerde ilk deger atamasi yapilmak zorundadir.
        //out > sayi yi  s nin degerinden  s ninn rreferansi haline getirir. ref te tanimlandigi yerde ilk deger atamasi fonksion icinde yapilabilir.
        static int SayiEkleREF(ref int sayi)
        {
            int sonuc = sayi += 5;

            return sonuc += 20;
        }
        static int SayiEkleOUT(out int sayi)
        {
            sayi = 10;
            int sonuc = sayi += 5;

            return sonuc += 20;
        }
        #endregion

        #region hata

        //Int.TryParse in icerigi
        static bool donusturmeyiDene(string deger, ref int s)
        {
            bool result = true;
            try
            {
                s = Convert.ToInt32(deger);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            return result;
        }



        #endregion

        #endregion

        #region Menu

        static string Kullanici = "";

        static string LoginSystem(string kAd, string sifre)
        {
            if (kAd == "Kreiger" && sifre == "Guest")
            {
                Console.WriteLine("Giris yapildi.");
                return kAd;
            }
            else Console.WriteLine("giris basarisiz.");
            return "";
        }

        static void Help()
        {
            Console.WriteLine("!!Help!!");
            Console.WriteLine("\"login\" \tGiris, ex. gir [Kullanici_adi] [sifre]");
            Console.WriteLine("\t\t\t NOT! Kullanici adi: \"Kreiger\", Sifre: \"Guest\". ");
            Console.WriteLine("\"clear\" \tEkrani temizler");
            Console.WriteLine("\"help\" \t\tBu mesaji gosterir");
            Console.WriteLine("\"exit\" \t\tCikis");
            Console.WriteLine("\nOrnekler!!");
            Console.WriteLine("\"exResize\" \tDinamik boyutlu dizi ornegine gecis");
            Console.WriteLine("\"galeri\" \tMatrix ile galeri otomat ornegine gecis.");
            Console.WriteLine("\"jungle\" \tJungle oyun ornegine gecis");
            Console.WriteLine("\"macskor\" \tMac Skor ornegine gecis");
            Console.WriteLine("\"fibo\" \t\tGirilen deger kadar fibonacci dizi degerini yazar. ex. fibo 10 ");
            Console.WriteLine("\"facq\" \t\tGirilen degerin faktoriyelini alir ex. facq 5");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\"help\" yazarak baslayiniz.");

            //string ad = "ali" == "a" ? "Ali degeri a(true)" : "Ali degeri a degil(false)";

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@" + Kullanici + " >>");
                Console.ResetColor();
                string strKomut = Console.ReadLine();
                string[] Parameters = strKomut.Split(' ');
                switch (Parameters[0])
                {
                    case "login":
                        if (Parameters.Length != 3)
                        {
                            Console.WriteLine("Eksik yada fazla parametre girildi. \"help\" yazarak dogru formati gorebilirsiniz.");
                        }
                        else
                            Kullanici = LoginSystem(Parameters[1], Parameters[2]);
                        break;
                    case "help":
                        Help();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        return;
                    case "main":
                        SideMain();
                        break;
                    default:
                        if (Kullanici == "") { Console.WriteLine("Orneklere erisebilmek icin giris yapiniz."); }

                        break;
                }

                if (Kullanici == "") { }
                else
                {
                    switch (Parameters[0])
                    {
                        case "exResize":
                            Console.WriteLine("ORNEK Dinamik Dizi\n1. Komut Kullan\n2.Menu Kullan");
                            while (true)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("@" + Kullanici + " >>");
                                Console.ResetColor();
                                byte c = Convert.ToByte(Console.ReadLine());
                                if (c == 1 || c == 2)
                                {
                                    ResizingArray(c);
                                    break;
                                }
                                Console.WriteLine("yanlis giris");
                            }
                            break;
                        case "fibo":
                            Fibonacci(Convert.ToInt32(Parameters[1]));
                            break;
                        case "galeri":
                            matrixArac();
                            break;
                        case "jungle":
                            Jungle();
                            break;
                        case "macskor":
                            macSkor();
                            break;
                        case "facq":
                            int a = facq(Convert.ToInt32(Parameters[1]));
                            Console.WriteLine(a);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        #endregion
    }
}
