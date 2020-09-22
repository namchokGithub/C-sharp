// Tutorial C Sharp
using System;

namespace C_sharp
{
    // Class: car
    // Author: Namchok
    class Car
    {
        public string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }

    // Class: Program
    // Author: Namchok
    class Program
    {
        static void myMethod()
        {
            Car c1 = new Car();
            Console.WriteLine("Color: " + c1.Color);
        }

        static void Main(string[] args)
        {
            myMethod();
        }
    }
}
