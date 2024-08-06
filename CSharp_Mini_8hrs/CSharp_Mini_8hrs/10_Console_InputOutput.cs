using System;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;

namespace CSharp_Mini_8hrs
    
{
    public class _10_Console_InputOutput
    {
        public void run()
        {
            /*
            System.Console.WriteLine("Hello my name is Sang!");
            System.Console.WriteLine("Enter your name here: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Hey hey Today is Aug 6, 2:06 AM " + name);
            */
            // write on the same line
            /*System.Console.Write("Enter your name here: ");

            System.Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            System.Console.WriteLine(age);
            */
            Console.Write("Enter your name here: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter your name here: " + name);
            
            Console.Write("Enter your age: ");
            var age = Console.ReadLine();
            Console.WriteLine("Enter your age: " + age);
            

        }
            
    }

}

