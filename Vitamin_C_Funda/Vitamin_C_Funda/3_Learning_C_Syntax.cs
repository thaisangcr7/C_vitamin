using System;

namespace Vitamin_C_Funda
{
    public class _3_Learning_C__Syntax

        {
            public void run()
            {
                Console.WriteLine("Hello, World!");

                Console.WriteLine("Please enter your name: ");
                string? name = Console.ReadLine(); // using console.readline is to accept intput from the console.
                Console.WriteLine("Hello " + name);

                Console.WriteLine("Please enter your age: ");
                string? ageInput = Console.ReadLine();
                //int age = Convert.ToInt32(ageInput);
                //int age = int.Parse(ageInput);
                //System.Console.WriteLine(" Your name is " + name + age + " year old");

                /* Better Option is using int.tryparse because it allows us
                to handle invalid input and avoid exceptions
                */

                if (int.TryParse(ageInput, out int age))
                    {
                        System.Console.WriteLine($"Hello {name}, you are {age} years old.");

                    }
                else
                    {
                        System.Console.WriteLine($"Invalid input {ageInput}");
                    }
            }


        }
}