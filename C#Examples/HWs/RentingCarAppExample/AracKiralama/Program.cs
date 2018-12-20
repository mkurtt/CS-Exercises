using System;

namespace AracKiralama
{
    class Program
    {
        static void MenuOlustur(params string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{i + 1}-");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(a[i]);
            }
            Console.ResetColor();
        }

        static void TypeColors()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Yellow");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Yellow");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Yellow");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Yellow");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Yellow");
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Yellow");
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Yellow");
                        break;
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Yellow");
                        break;
                    default:
                        break;
                }
                Console.ResetColor();
                Console.Write(", ");
            }

        }

        public static void Write(Object str, Colors c)
        {
            if (c == Colors.DarkCyan) Console.ForegroundColor = ConsoleColor.DarkCyan;
            else if (c == Colors.Green) Console.ForegroundColor = ConsoleColor.Green;
            else if (c == Colors.Red) Console.ForegroundColor = ConsoleColor.Red;
            else if (c == Colors.White) Console.ForegroundColor = ConsoleColor.White;
            else if (c == Colors.Blue) Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write($"{str}");
            Console.ResetColor();
        }

        public enum Colors
        {
            DarkCyan,
            Green,
            Red,
            White,
            Blue
        }

        static int CreateSN()
        {
            Random a = new Random();
            int mySN;
            while (true)
            {
                mySN = a.Next(10000,100000);
                int Y = 0;
                for (int i = 0; i < Cars.Length; i++)
                {
                    if (Cars[i].sn == mySN) break;
                    Y++;
                }
                if (Y == Cars.Length) break;
            }
            return mySN;
        }

        static void AddCar()
        {
            string str = "";
            int X;
            Car c = new Car();

            c.sn = CreateSN();

            Write("Marka: ", Colors.DarkCyan);
            c.brand = Console.ReadLine().ToUpper();

            Write("Model: ", Colors.DarkCyan);
            c.model = Console.ReadLine().ToUpper();

            //TypeColors();

            Write("Renk: ", Colors.DarkCyan);
            c.color = Console.ReadLine().ToUpper();

            #region Colors
            //color.ToLower();
            //switch (color)
            //{
            //    case "yellow":
            //        c.color = Car.Color.YELLOW;
            //        break;
            //    case "red":
            //        c.color = Car.Color.RED;
            //        break;
            //    case "green":
            //        c.color = Car.Color.GREEN;
            //        break;
            //    case "blue":
            //        c.color = Car.Color.BLUE;
            //        break;
            //    case "gray":
            //        c.color = Car.Color.GRAY;
            //        break;
            //    case "cyan":
            //        c.color = Car.Color.CYAN;
            //        break;
            //    case "black":
            //        c.color = Car.Color.BLACK;
            //        break;
            //    case "magenta":
            //        c.color = Car.Color.MAGENTA;
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            //Year
            while (true)
            {
                Write("Years: ", Colors.DarkCyan);
                str = Console.ReadLine();

                if (int.TryParse(str, out X))
                {
                    c.year = Convert.ToString(X);
                    break;
                }
                else
                {
                    Write("Sayisal deger giriniz.", Colors.Red);
                }
            }

            //Vites
            while (true)
            {
                Write("Vites Tipi\n", Colors.DarkCyan);
                MenuOlustur("Duz", "Otomatik");
                Write(">>", Colors.DarkCyan);
                str = Console.ReadLine();
                bool Y = false;
                if (int.TryParse(str, out X))
                {
                    switch (X)
                    {
                        case 1:
                            Y = true;
                            c.automatic = false;
                            break;
                        case 2:
                            Y = true;
                            c.automatic = true;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Write("Sayisal deger giriniz.", Colors.Red);
                }
                if (Y == true) break;
            }

            //Fiyat
            while (true)
            {
                Write("Fiyat: ", Colors.DarkCyan);
                str = Console.ReadLine();

                if (int.TryParse(str, out X))
                {
                    c.price = X;
                    break;
                }
                else
                {
                    Write("Sayisal deger giriniz.", Colors.Red);
                }
            }

            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;
        }

        static void Help()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("!!Help!!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\"ekle\" \t\tYeni arac ekler.");
            Console.WriteLine("\"ara\" \t\tEklenen araclarda arar.");
            Console.WriteLine("\tara  > butun araclari listeler");
            Console.WriteLine("\tara k  > kiradaki araclari listeler");
            Console.WriteLine("\tara g  > galerideki araclari listeler");
            Console.WriteLine("\tara m [marka]  > marka aramasi yapar");
            Console.WriteLine("\tara f [Tam Deger]  > tam fiyati verilen araclari listeler");
            Console.WriteLine("\tara f [1.deger] [2.deger]  > verilen degerler arasinda fiyata sahip araclari listeler");
            
            Console.WriteLine("\"kira\" \t\tArac kiralama Ex. kira [S/N]");
            Console.WriteLine("\"al\" \t\tKiralanan araci geri al Ex. al [S/N]");
            Console.WriteLine("\"clear\" \tEkrani temizler");
            Console.WriteLine("\"help\" \t\tBu mesaji gosterir");
            Console.WriteLine("\"exit\" \t\tCikis");
            Console.ResetColor();
        }

        static Car[] Cars = new Car[0];

        static void AutoAdd()
        {
            Car c = new Car();
            c.sn = CreateSN();
            c.brand = "FORD";
            c.model = "FIESTA";
            c.color = "WHITE";
            c.year = "2011";
            c.automatic = false;
            c.price = 35000;
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;

            c = new Car();
            c.sn = CreateSN();
            c.brand = "FORD";
            c.model = "FOCUS";
            c.color = "BLACK";
            c.year = "2014";
            c.automatic = true;
            c.price = 66900;
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;

            c = new Car();
            c.sn = CreateSN();
            c.brand = "FORD";
            c.model = "MONDEO";
            c.color = "RED";
            c.year = "2008";
            c.automatic = false;
            c.price = 97000;
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;

            c = new Car();
            c.sn = CreateSN();
            c.brand = "OPEL";
            c.model = "ASTRA";
            c.color = "WHITE";
            c.year = "2016";
            c.automatic = false;
            c.price = 84000;
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;

            c = new Car();
            c.sn = CreateSN();
            c.brand = "OPEL";
            c.model = "CORSA";
            c.color = "BLACK";
            c.year = "2008";
            c.automatic = false;
            c.price = 35000;
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = c;
        }

        static void Main(string[] args)
        {
            AutoAdd();

            Write("ARAC GALERISI ORNEK PROGRAM\n", Colors.DarkCyan);
            Write("\"help\" yazarak baslayiniz.\n", Colors.DarkCyan);

            while (true)
            {
                Write("@ >>", Colors.Green);
                string strKomut = Console.ReadLine();
                string[] Parameters = strKomut.Split(' ');
                switch (Parameters[0])
                {
                    case "ekle":
                        AddCar();
                        break;
                    case "ara":
                        if (Parameters.Length >= 2)
                        {
                            switch (Parameters[1])
                            {
                                case "f":
                                    int f;
                                    if (Parameters.Length >= 3)
                                    {
                                        if (int.TryParse(Parameters[2], out f))
                                        {
                                            int f2;
                                            if (Parameters.Length >= 4)
                                            {
                                                if (int.TryParse(Parameters[3], out f2))
                                                {
                                                    for (int i = 0; i < Cars.Length; i++)
                                                    {
                                                        if ((Cars[i].price > f && Cars[i].price < f2) || (Cars[i].price < f && Cars[i].price > f2))
                                                        {
                                                            Cars[i].CarDetails();
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    for (int i = 0; i < Cars.Length; i++)
                                                    {
                                                        if (Cars[i].price == f)
                                                        {
                                                            Cars[i].CarDetails();
                                                        }
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                for (int i = 0; i < Cars.Length; i++)
                                                {
                                                    if (Cars[i].price == f)
                                                    {
                                                        Cars[i].CarDetails();
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Write("Sayisal deger giriniz.\n", Colors.Red);
                                        }
                                    }
                                    break;

                                case "m":
                                    if (Parameters.Length >= 3)
                                    {
                                        for (int i = 0; i < Cars.Length; i++)
                                        {
                                            if (Cars[i].brand.Contains(Parameters[2]))
                                            {
                                                Cars[i].CarDetails();
                                            }
                                        }
                                    }
                                    break;

                                case "k":
                                    if (Parameters.Length >= 2)
                                    {
                                        for (int i = 0; i < Cars.Length; i++)
                                        {
                                            if (Cars[i].rented == true)
                                            {
                                                Cars[i].CarDetails();
                                            }
                                        }
                                    }
                                    break;

                                case "g":
                                    if (Parameters.Length >= 2)
                                    {
                                        for (int i = 0; i < Cars.Length; i++)
                                        {
                                            if (Cars[i].rented == false)
                                            {
                                                Cars[i].CarDetails();
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            for (int i = 0; i < Cars.Length; i++)
                            {
                                Cars[i].CarDetails();
                            }
                        }
                        break;
                    case "kira":
                        if (Parameters.Length >= 2)
                        {
                            int sn;
                            if (int.TryParse(Parameters[1], out sn))
                            {
                                for (int i = 0; i < Cars.Length; i++)
                                {
                                    if (Cars[i].sn == sn && Cars[i].rented == false)
                                    {
                                        Cars[i].rented = true;
                                        Write("Kiralama Basarili!\n", Colors.Green);
                                        Cars[i].CarDetails();
                                    }
                                    else if (Cars[i].sn == sn && Cars[i].rented == true)
                                    {
                                        Write("Kiralama Basarisiz, Arac Zaten Kirada.\n", Colors.Red);
                                    }
                                    else Write("Kiralama Basarisiz, Arac Bulunamadi.\n", Colors.Red);
                                }
                            }
                            else
                            {
                                Write("Sayisal deger giriniz.\n", Colors.Red);
                            }
                        }
                        break;
                    case "al":
                        if (Parameters.Length >= 2)
                        {
                            int sn;
                            if (int.TryParse(Parameters[1], out sn))
                            {
                                for (int i = 0; i < Cars.Length; i++)
                                {
                                    if (Cars[i].sn == sn && Cars[i].rented == true)
                                    {
                                        Cars[i].rented = false;
                                        Write("Geri Alma Basarili!\n", Colors.Green);
                                        Cars[i].CarDetails();
                                    }
                                    else if (Cars[i].sn == sn && Cars[i].rented == false)
                                    {
                                        Write("Kiralama Basarisiz, Arac Zaten Galeride.\n", Colors.Red);
                                    }
                                    else Write("Kiralama Basarisiz, Arac Bulunamadi.\n", Colors.Red);
                                }
                            }
                            else
                            {
                                Write("Sayisal deger giriniz.\n", Colors.Red);
                            }
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
    }
}
