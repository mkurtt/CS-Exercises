using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = new int[0];

            while (true)
            {
                Console.WriteLine("\nsayi gir : ");
                int zxc = Convert.ToInt32(Console.ReadLine());

                
                int[] qwe = new int[asd.Length];
                for (int j = 0; j < asd.Length; j++)
                {
                    qwe[j] = asd[j];
                }

                asd = new int[qwe.Length + 1];
                for (int j = 0; j < qwe.Length; j++)
                {
                    asd[j] = qwe[j];
                }
                asd[asd.Length - 1] = zxc;


                for (int j = 0; j < asd.Length; j++)
                {
                    Console.Write(asd[j]);
                }
            }
        }
    }
}
