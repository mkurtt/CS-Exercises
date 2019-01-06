using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{
    public class Vehicle
    {
        public string Color { get; set; }

        public string Model { get; set; }

        public string Marka { get; set; }

        public virtual string GetValues()
        {
            return $"\nColor:{Color}, Model:{Model}, Marka:{Marka}";
        }
    }
}
