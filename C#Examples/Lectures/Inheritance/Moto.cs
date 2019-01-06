using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{
    public enum MotoType
    {
        Enduro, Chopper, Sport, Scooter
    }
    public class Moto : Vehicle
    {
        public MotoType Type { get; set; }

        public override string GetValues()
        {
            return base.GetValues() + " MotoType: " + Type;
        }
    }
}
