using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{
    public sealed class Controller
    {
        public static Vehicle AddValues(Vehicle V)
        {
            Console.Write("Color: ");
            V.Color = Console.ReadLine();
            Console.Write("Marka: ");
            V.Marka = Console.ReadLine();
            Console.Write("Model: ");
            V.Model = Console.ReadLine();

            return V;
        }

        public static void AddVehicle(Vehicle V)
        {
            if (V is Truck)
            {
                V = (Truck)V;
                File.AppendAllText("D:\\Vehicles.txt", V.GetValues());
            }
            else if (V is Car)
            {
                V = (Car)V;
                File.AppendAllText("D:\\Vehicles.txt", V.GetValues());
            }
            else if (V is Moto)
            {
                V = (Moto)V;
                File.AppendAllText("D:\\Vehicles.txt", V.GetValues());
            }
        }
        
    }
}
