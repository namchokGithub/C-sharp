// Tutorial C Sharp
using System.Security.Cryptography;
using System;
using System.Linq;

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

        static void setColor(string color = "black")
        {
            string temp = color;
            color = temp;
        }
    }

    // Class: Program
    // Author: Namchok
    class Program
    {
        static void myMethod()
        {
            System.Console.WriteLine("Test");

            Car c1 = new Car();
            // c1.getColor();
        }

        static void hashkey()
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            Hash hashResultSha256 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA256.Create());
            Hash hashResultSha512 = pwHasher.HashWithSalt("ultra_safe_P455w0rD", 64, SHA512.Create());

            Console.WriteLine(hashResultSha256.Salt);
            Console.WriteLine(hashResultSha256.Digest);
            Console.WriteLine();
            Console.WriteLine(hashResultSha512.Salt);
            Console.WriteLine(hashResultSha512.Digest);
        }

        static void Main(string[] args)
        {

            hashkey();

            // try
            // {
            //     int[] myNumber = { 1, 2, 3 };
            //     System.Console.WriteLine(myNumber[11]);
            // }
            // catch (System.Exception)
            // {
            //     System.Console.WriteLine("Something went wrong");
            //     // throw;
            // }
            // finally
            // {
            //     Console.WriteLine("The 'try catch' is finished.");
            // }
            // myMethod();
            // Console.WriteLine("Hello World!");

            // // https://www.w3schools.com/cs

            // // data type
            // int a = 10;
            // double b = 11.1;
            // char c = 'c';
            // string d = "Dog";
            // bool e = false;

            // string name = "John";
            // Console.WriteLine("Hello " + name);

            // // casting
            // int myInt = 10;
            // double myDouble = 5.25;
            // bool myBool = true;

            // Console.WriteLine(Convert.ToString(myInt));
            // Console.WriteLine(Convert.ToDouble(myInt));
            // Console.WriteLine(Convert.ToInt32(myDouble));
            // Console.WriteLine(Convert.ToString(myBool));

            // //  User input
            // // Type your username and press enter
            // // Console.WriteLine("Enter username:");

            // // // Create a string variable and get user input from the keyboard and store it in the variable
            // // string userName = Console.ReadLine();

            // // // Print the value of the variable (userName), which will display the input value
            // // Console.WriteLine("Username is: " + userName);

            // System.Console.WriteLine(Math.Max(5, 10));

            // // if else
            // if (1 > 2)
            // {
            //     System.Console.WriteLine(22);
            // }
            // else
            // {
            //     System.Console.WriteLine(12123);
            // }

            // // short hand if else 
            // int time = 20;
            // string result = (time < 18) ? "Good day." : "Good evening.";
            // Console.WriteLine(result);

            // // while loop
            // int i = 0;
            // do
            // {
            //     Console.WriteLine(i);
            //     i++;
            // }
            // while (i < 5);

            // // for loop
            // for (int bb = 0; bb < 5; bb++)
            // {
            //     Console.WriteLine(bb);
            // }

            // // array
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            // foreach (string rr in cars)
            // {
            //     Console.WriteLine(rr);
            // }
            // Array.Sort(cars);
            // foreach (string rr in cars)
            // {
            //     Console.WriteLine(rr);
            // }

            // // System.Linq Namespace
            // int[] myNumbers = { 5, 1, 8, 9 };
            // Console.WriteLine(myNumbers.Max());  // returns the largest value
            // Console.WriteLine(myNumbers.Min());  // returns the smallest value
            // Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
        }
    }
}
