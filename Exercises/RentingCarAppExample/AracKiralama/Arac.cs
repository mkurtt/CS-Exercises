using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama
{
    class Car
    {
        public int sn;
        public string brand;
        public string model;
        public string color;
        public string year;

        public bool automatic;

        public decimal price;

        public bool rented;

        public Car()
        {
            rented = false;
        }

        //public static enum Color
        //{
        //    YELLOW = 0,
        //    RED = 1,
        //    GREEN = 2,
        //    BLUE = 3,
        //    GRAY = 4,
        //    CYAN = 5,
        //    BLACK = 6,
        //    MAGENTA = 7
        //}

        public void CarDetails()
        {
            Program.Write("S/N: ", Program.Colors.Blue);
            Program.Write(sn, Program.Colors.White);
            Program.Write("\nBrand: ", Program.Colors.Red);
            Program.Write(brand, Program.Colors.White);
            Program.Write(" Model: ", Program.Colors.Red);
            Program.Write(model, Program.Colors.White);
            Program.Write(" Year: ", Program.Colors.Red);
            Program.Write(year, Program.Colors.White);
            Program.Write("\nColor: ", Program.Colors.Red);
            Program.Write(color, Program.Colors.White);
            Program.Write(" Vites: ", Program.Colors.Red);
            if (automatic) Program.Write("Otomatik", Program.Colors.White);
            else Program.Write("Duz", Program.Colors.White);
            Program.Write(" Price: ", Program.Colors.Red);
            Program.Write(price, Program.Colors.White);

            Program.Write("\nKira Durumu: ", Program.Colors.Red);
            if (rented) Program.Write("Kirada\n", Program.Colors.Red);
            else Program.Write("Galeride\n", Program.Colors.Green);

        }
    }
}
