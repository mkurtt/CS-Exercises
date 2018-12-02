using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ResizingArray
                
            string[] ogrenci = new string[0];
            bool X = false;
            do
            {
                Console.WriteLine("MENU \n1-Ogrenci Ekle\n2-Listele\n3-ogrenci ara\n4-ogrenci sil\n5-dosya yaz\n6-Cikis\n >>>");
                int q = Convert.ToInt32(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        Console.WriteLine("ogrenci ismini giriniz: ");
                        string ad = Console.ReadLine();
                        Console.WriteLine("ogrenci soyad giriniz: ");
                        string soyad = Console.ReadLine();

                        string[] qwe = new string[ogrenci.Length];
                        for (int j = 0; j < ogrenci.Length; j++)
                        {
                            qwe[j] = ogrenci[j];
                        }

                        ogrenci = new string[qwe.Length + 1];
                        for (int j = 0; j < qwe.Length; j++)
                        {
                            ogrenci[j] = qwe[j];
                        }
                        ogrenci[ogrenci.Length - 1] = ad + " " + soyad;

                        break;
                    case 2:
                        for (int j = 0; j < ogrenci.Length; j++)
                        {
                            Console.Write(ogrenci[j] + " " + ogrenci[j] + "\n");
                            File.AppendAllText("d:\\ogrenci.txt", ogrenci[j] + " " + ogrenci[j] + "\n");
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ara: ");
                        string qwer = Console.ReadLine();

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
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Sil: ");
                        string asdf = Console.ReadLine();
                        int indisI = 0;
                        int Z = 0;
                        for (int i = 0; i < ogrenci.Length; i++)
                        {
                            if (ogrenci[i].Contains(asdf))
                            {
                                Console.Write(ogrenci[i] + " " + ogrenci[i] + "\n");
                                Z++;
                                indisI = i;
                            }
                        }
                        if (Z > 1)
                        {
                            Console.WriteLine("daha kesin bir giris yapiniz");
                            Console.ReadKey();
                            break;
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
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        for (int j = 0; j < ogrenci.Length; j++)
                        {
                            File.AppendAllText("d:\\ogrenci.txt", ogrenci[j] + " " + ogrenci[j] + "\n");
                        }
                        break;
                    case 6:
                        X = true;
                        break;
                    default:
                        Console.WriteLine("yanlis giris");
                        break;
                }
                Console.Clear();

            } while (X == false);
            
            #endregion
                
            #region matrix

            Console.Write("kac kolon oynanacak(1-12): ");
            byte kolon = Convert.ToByte(Console.ReadLine());

            byte[,] loto = new byte[kolon, 6];

            byte[] sonuclar = new byte[6];

            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                byte qwe = Convert.ToByte(rnd.Next(1, 49));
                if (sonuclar[i] < 50 || sonuclar[i] > 0)
                    sonuclar[i] = qwe;
            }

            Array.Sort(sonuclar);

            for (int i = 0; i < kolon; i++)
            {
                Console.Write((i + 1) + ". kolon icin 6 deger gir (\" \" kullanarak)(1-49): ");
                string degerlerrrrr = Console.ReadLine();
                string[] degeler = degerlerrrrr.Split(' ');
                byte[] temp = new byte[6];
                for (int j = 0; j < 6; j++)
                {
                    temp[j] = Convert.ToByte(degeler[j]);
                    if (loto[i, j] > 50 || loto[i, j] < 0)
                    {
                        i--;
                        Console.WriteLine("gecersiz deger girildi.");
                    }
                }
                Array.Sort(temp);
                for (int j = 0; j < 6; j++)
                {
                    loto[i, j] = temp[j];
                }
            }

            bool[] asd = new bool[kolon];

            for (int i = 0; i < kolon; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (sonuclar[j] != loto[i, j])
                    {
                        asd[i] = true;
                        break;
                    }
                }
            }
            Console.Write("kazanan degerler: ");
            for (int j = 0; j < 6; j++)
            {
                Console.Write(sonuclar[j] + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < kolon; i++)
            {
                if (asd[i] == false)
                {
                    Console.WriteLine((i + 1) + ". kolon TUTTU.");
                }else Console.WriteLine((i + 1) + ". kolon tutmadi.");

            }

            Console.ReadKey();

            #endregion    
                
            #region matrix arac
            int Butce = 0;
            const byte garajBoyutu = 100;
            byte currentCarIndex = 0;
            string[,] araclar = new string[garajBoyutu, 4];
            // marka model fiyat kira
            bool X = false;

            araclar[currentCarIndex, 0] = "BMW";
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
                                Console.WriteLine($"{Z1+1}. Marka: {araclar[i, 0]}, Model: {araclar[i, 1]}, Kira Fiyati: {araclar[i, 2]}");
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
                            if (Y1[i] == zxc1-1)
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
                Console.Clear();
            }

            #endregion       
        }
    }
}
