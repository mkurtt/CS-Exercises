using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        #region Menu

        static void Help()
        {
            Console.WriteLine("!!Help!!");
            Console.WriteLine("\"ekle\" \t\tYeni ev ekler.");
            Console.WriteLine("\"bul\" \t\tEklenen evlerde arar. ex. bul [] ");
            Console.WriteLine("\"clear\" \tEkrani temizler");
            Console.WriteLine("\"help\" \t\tBu mesaji gosterir");
            Console.WriteLine("\"exit\" \t\tCikis");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Emlak Programi");
            Console.WriteLine("\"help\" yazarak baslayiniz.");

            Ev[] evler = new Ev[0];

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("@  >>");
                Console.ResetColor();
                string strKomut = Console.ReadLine();
                string[] Parameters = strKomut.Split(' ');
                switch (Parameters[0])
                {
                    case "ekle":
                        Ev e = new Classes.Ev();
                        Console.Write("Semt: ");
                        e.semt = Console.ReadLine();
                        Console.Write("Mahalle: ");
                        e.mahalle = Console.ReadLine();
                        Console.Write("Oda Sayisi: ");
                        e.odaSayisi = Convert.ToByte(Console.ReadLine());
                        Console.Write("Metrekare: ");
                        e.metrekare = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Fiyat: ");
                        e.fiyat = Convert.ToDecimal(Console.ReadLine());

                        Array.Resize(ref evler, evler.Length + 1);
                        evler[evler.Length - 1] = e;

                        Console.WriteLine(e.BilgileriGetir() + "  Eklendi!");
                        break;
                    case "bul":
                        
                        switch (Parameters[1])
                        {
                            case "mk":
                                int mk;
                                if (Parameters.Length == 4)
                                {
                                    if (int.TryParse(Parameters[3], out mk))
                                    {
                                        int mk2;
                                        if (int.TryParse(Parameters[2], out mk2))
                                        {
                                            for (int i = 0; i < evler.Length; i++)
                                            {
                                                if ((evler[i].metrekare > mk && evler[i].metrekare < mk2) || (evler[i].metrekare < mk && evler[i].metrekare > mk2))
                                                {
                                                    Console.WriteLine(evler[i].BilgileriGetir());
                                                }
                                            }
                                        }
                                    }
                                }
                                else if(Parameters.Length==3)
                                {
                                    if (int.TryParse(Parameters[2], out mk))
                                    {
                                        for (int i = 0; i < evler.Length; i++)
                                        {
                                            if (evler[i].metrekare == mk)
                                            {
                                                Console.WriteLine(evler[i].BilgileriGetir());
                                            }
                                        }
                                    }
                                }
                                break;
                            case "f":
                                int f;
                                if (int.TryParse(Parameters[2], out f))
                                {
                                    for (int i = 0; i < evler.Length; i++)
                                    {
                                        if (evler[i].fiyat == f)
                                        {
                                            Console.WriteLine(evler[i].BilgileriGetir());
                                        }
                                    }
                                }
                                break;
                            case "mh":
                                for (int i = 0; i < evler.Length; i++)
                                {
                                    if (evler[i].mahalle == Parameters[2])
                                    {
                                        Console.WriteLine(evler[i].BilgileriGetir());
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "help":
                        Help();
                        break;
                    case "clear":
                        Console.Clear();
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }

            }
        }

        #endregion
    }
}
