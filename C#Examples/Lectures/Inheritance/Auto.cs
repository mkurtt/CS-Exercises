using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public override string GetValues()
        {
            return base.GetValues() + " Seats: " + Seats;
        }
    }
}
