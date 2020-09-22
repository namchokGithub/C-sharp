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

        static void Main(string[] args)
        {
            TypeCasting();
        } // End main
        
        static void DataType() 
        {
            int typeInd = 1000000000; // 4 bytes Stores whole numbers from -2,147,483,648 to 2,147,483,647
            long typeLong = 1000000000000000000; // 8 bytes Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            float typeFloat = 1.1234567F; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            double typeDouble = 1.1233456789123456; // Stores fractional numbers. Sufficient for storing 15 decimal digits
            bool typeBool = true; 
            char typeChar = 'a';
            string typeString = "string";

            Console.WriteLine(typeInd);
            Console.WriteLine(typeLong);
            Console.WriteLine(typeFloat);
            Console.WriteLine(typeDouble);
            Console.WriteLine(typeBool);
            Console.WriteLine(typeChar);
            Console.WriteLine(typeString);
        } // End data type
        
        static void myMethod()
        {
            Car c1 = new Car();
            Console.WriteLine("Color: " + c1.Color);
        } // End myMethod

        static void TypeCasting() {
            /*
            Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
            */
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        } // End type casting 
    }
}
