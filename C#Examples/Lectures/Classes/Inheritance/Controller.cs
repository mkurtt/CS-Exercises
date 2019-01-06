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
        public static T AddValues<T>() where T : Vehicle, new()
        {
            T t = new T();
            Console.Write("Color: ");
            t.Color = Console.ReadLine();
            Console.Write("Marka: ");
            t.Marka = Console.ReadLine();
            Console.Write("Model: ");
            t.Model = Console.ReadLine();
            
            return t as T;
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
