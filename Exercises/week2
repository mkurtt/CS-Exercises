#region matrix Ogrenci


            const byte OkulKontenjan = 100;
            byte AnlikOgrenciSayisi = 0;
            string[,] ogrenciler = new string[OkulKontenjan, 5];
            // Ad Soyad No Not1 Not2
            bool X = false;

            string[,] isimler = new string[10, 2];

            isimler[0, 0] = "Ayse";
            isimler[1, 0] = "Ali";
            isimler[2, 0] = "Veli";
            isimler[3, 0] = "Mehmet";
            isimler[4, 0] = "Burak";
            isimler[5, 0] = "Mete";
            isimler[6, 0] = "Gulsum";
            isimler[7, 0] = "Mustafa";
            isimler[8, 0] = "Gul";
            isimler[9, 0] = "Sevin";

            isimler[0, 1] = "Kurtulan";
            isimler[1, 1] = "Baklavacioglu";
            isimler[2, 1] = "Altin";
            isimler[3, 1] = "Kayaci";
            isimler[4, 1] = "Ozgur";
            isimler[5, 1] = "Dogan";
            isimler[6, 1] = "Sahin";
            isimler[7, 1] = "Tekel";
            isimler[8, 1] = "Tezel";
            isimler[9, 1] = "Telli";

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                ogrenciler[AnlikOgrenciSayisi, 0] = isimler[i, 0];
                ogrenciler[AnlikOgrenciSayisi, 1] = isimler[i, 1];
                ogrenciler[AnlikOgrenciSayisi, 2] = Convert.ToString(i + 1);
                ogrenciler[AnlikOgrenciSayisi, 3] = Convert.ToString(rnd.Next(100));
                ogrenciler[AnlikOgrenciSayisi, 4] = Convert.ToString(rnd.Next(100));
                AnlikOgrenciSayisi++;
            }
            Console.WriteLine($"Komutlar icin \"help\" yaziniz.");
            while (true)
            {
                
                Console.Write(">>");
                string c = Console.ReadLine();
                string[] zxc = new string[2];
                if (c.Contains("ara"))
                {
                    zxc = c.Split(' ');
                    c = zxc[0];

                }

                switch (c)
                {
                    case "help":
                        Console.WriteLine("\" ekle \" \t\t Ogrenci ekleme. \n\" ara [Ogrenci_no] \" \t Arama yapma. ex. ara 123\n\" mevcut \" \t\t Mecvut Ogrenci Sayisi. \n\" exit \" \t\t Cikis yapma. \n\" help \" \t\t Bu mesaji goruntulemek. ");
                        
                        break;
                    case "ekle":
                        Console.WriteLine("Ogrencinin");
                        
                        while (true)
                        {
                            Console.Write("Adi: ");
                            ogrenciler[AnlikOgrenciSayisi, 0] = Console.ReadLine();
                            if (ogrenciler[AnlikOgrenciSayisi, 0] == "")
                            {
                                Console.WriteLine("Ad girisi yapilmadi.");
                            }
                            else break;
                        }

                        while (true)
                        {
                            Console.Write("Soyadi: ");
                            ogrenciler[AnlikOgrenciSayisi, 1] = Console.ReadLine();
                            if (ogrenciler[AnlikOgrenciSayisi, 1] == "")
                            {
                                Console.WriteLine("Soyad girisi yapilmadi.");
                            }
                            else break;
                        }

                        Console.Write("Numarasi: ");
                        bool asd = false;
                        while (true)
                        {
                            asd = false;
                            
                            ogrenciler[AnlikOgrenciSayisi, 2] = Console.ReadLine();

                            for (int i = 0; i < AnlikOgrenciSayisi; i++)
                            {
                                if (ogrenciler[i, 2] == ogrenciler[AnlikOgrenciSayisi, 2])
                                {
                                    Console.Write("Bu No ile ogrenci kaydi bulunmaktadir.\n Yeni No giriniz: ");
                                    asd = true;
                                    break;
                                }else if(ogrenciler[AnlikOgrenciSayisi, 2] == "")
                                {
                                    Console.Write("Giris yapmadiniz\n Yeni No giriniz: ");
                                    asd = true;
                                    break;
                                }
                            }
                            if (asd == false) break;
                        }

                        while (true)
                        {
                            Console.Write("Not1: ");
                            ogrenciler[AnlikOgrenciSayisi, 3] = Console.ReadLine();

                            if (ogrenciler[AnlikOgrenciSayisi, 3] == "")
                            {
                                Console.Write("Giris yapmadiniz\n Yeniden giriniz: ");
                            }
                            else if (Convert.ToInt32(ogrenciler[AnlikOgrenciSayisi, 3]) > 100 || Convert.ToInt32(ogrenciler[AnlikOgrenciSayisi, 3]) < 0)
                            {
                                Console.WriteLine("Girilen not 0-100 arasinda olmali.");
                            }
                            
                            else break;
                        }
                        while (true)
                        {
                            Console.Write("Not2: ");
                            ogrenciler[AnlikOgrenciSayisi, 4] = Console.ReadLine();

                            if (ogrenciler[AnlikOgrenciSayisi, 4] == "")
                            {
                                Console.Write("Giris yapmadiniz\n Yeniden giriniz: ");
                            }
                            else if (Convert.ToInt32(ogrenciler[AnlikOgrenciSayisi, 4]) > 100 || Convert.ToInt32(ogrenciler[AnlikOgrenciSayisi, 4]) < 0)
                            {
                                Console.WriteLine("Girilen not 0-100 arasinda olmali.");
                            }
                            else break;
                        }
                        
                        AnlikOgrenciSayisi++;


                        Console.WriteLine("Ogrenci Eklendi!");
                        break;
                    case "ara":
                        string arananNo = zxc[1];
                        bool V = false;
                        for (int i = 0; i < AnlikOgrenciSayisi; i++)
                        {
                            if (ogrenciler[i, 2] == arananNo)
                            {
                                int Ort = (Convert.ToInt32(ogrenciler[i, 3]) + Convert.ToInt32(ogrenciler[i, 4])) / 2;
                                Console.WriteLine($"{ogrenciler[i, 2]} Nolu: {ogrenciler[i, 0]} {ogrenciler[i, 1]}, Not Ortalamasi: {Ort} ");
                                V = true;
                            }
                        }
                        if (V == false)
                        {
                            Console.WriteLine("Bu numarada ogrenci yok!");
                            break;
                        }
                        
                        break;
                    case "mevcut":
                        Console.WriteLine("Mevcut Ogrenci sayisi: " + AnlikOgrenciSayisi);
                        break;
                    case "exit":
                        X = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis giris.");
                        break;
                }

                if (X == true)
                {
                    break;
                }

                
            }

            #endregion       
