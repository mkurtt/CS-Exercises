using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.KalitimTekrar.App
{ 
    public class Truck : Vehicle
    {
        public int Wheels { get; set; }

        public override string GetValues()
        {
            return base.GetValues()+" Dingil Sayısı: "+ Wheels;
        }
    }
}
