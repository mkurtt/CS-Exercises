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
            
        }
    }
}
