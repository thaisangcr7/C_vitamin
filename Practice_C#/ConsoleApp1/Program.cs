using System;
using System.Diagnostics;

namespace Helloworld
{
    class Program
    {
        // this is the main method
        static void Main(string[] args)
        {
            WriteSomething();
            int result = Calculation();
            Console.WriteLine($"result is {result}");
            Console.ReadLine();
        }

        // Access modifier (static) return method name (parameter1, parameter2)
        // Why static - whenever you want to call a method within a static method, you need to
        // make the method itself static as well        
        public static void WriteSomething()
        {
            System.Console.WriteLine(" i am called from the method");
            Console.ReadLine();
        }

        public static int Calculation()
        {
            // int num1 = 10;
            // int num2 = 10;
            // int result = num1 + num2;
            // return result;

            //ask for user inputs
            Console.Write("Please enter your your num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your num2: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            return result;
        }
    }
}



