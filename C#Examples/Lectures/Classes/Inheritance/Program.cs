using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Truck\n2-Car\n3-Moto\n4-Exit>>");
                char c = Console.ReadKey(true).KeyChar;

                switch (c)
                {
                    case '1':
                        Truck T = Controller.AddValues<Truck>();

                        Console.Write("Wheels: ");
                        T.Wheels = Convert.ToInt32(Console.ReadLine());
                        Controller.AddVehicle(T);
                        break;
                    case '2':
                        Car C = (Car)Controller.AddValues(V);
                        
                        Console.Write("Seats: ");
                        C.Seats = Convert.ToInt32(Console.ReadLine());
                        Controller.AddVehicle(C);
                        break;
                    case '3':
                        Moto M = (Moto)Controller.AddValues(V);
                        
                        Console.WriteLine("Type:\n1-Enduro\n2-Chopper\n3-Sport\n4-Scooter ");
                        c = Console.ReadKey(true).KeyChar;
                        bool A = true;
                        while (A)
                        {
                            switch (c)
                            {
                                case '1':
                                    M.Type = MotoType.Enduro;
                                    A = false;
                                    break;
                                case '2':
                                    M.Type = MotoType.Chopper;
                                    A = false;
                                    break;
                                case '3':
                                    M.Type = MotoType.Sport;
                                    A = false;
                                    break;
                                case '4':
                                    M.Type = MotoType.Scooter;
                                    A = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        Controller.AddVehicle(M);
                        break;
                    case '4':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
