// Tutorial C Sharp

using System;
using System.Linq;

namespace C_sharp
{
    // Class: car
    // Author: Namchok
    class car
    {

    }

    // Class: Program
    // Author: Namchok
    class Program
    {

        static void myMethod()
        {
            System.Console.WriteLine("Test");
        }
        static void Main(string[] args)
        {
            myMethod();
            Console.WriteLine("Hello World!");

            // https://www.w3schools.com/cs

            // data type
            int a = 10;
            double b = 11.1;
            char c = 'c';
            string d = "Dog";
            bool e = false;

            string name = "John";
            Console.WriteLine("Hello " + name);

            // casting
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            //  User input
            // Type your username and press enter
            // Console.WriteLine("Enter username:");

            // // Create a string variable and get user input from the keyboard and store it in the variable
            // string userName = Console.ReadLine();

            // // Print the value of the variable (userName), which will display the input value
            // Console.WriteLine("Username is: " + userName);

            System.Console.WriteLine(Math.Max(5, 10));

            // if else
            if (1 > 2)
            {
                System.Console.WriteLine(22);
            }
            else
            {
                System.Console.WriteLine(12123);
            }

            // short hand if else 
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            // while loop
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            // for loop
            for (int bb = 0; bb < 5; bb++)
            {
                Console.WriteLine(bb);
            }

            // array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string rr in cars)
            {
                Console.WriteLine(rr);
            }
            Array.Sort(cars);
            foreach (string rr in cars)
            {
                Console.WriteLine(rr);
            }

            // System.Linq Namespace
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}
