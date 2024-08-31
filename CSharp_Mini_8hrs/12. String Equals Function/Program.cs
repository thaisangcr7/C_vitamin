using System.Security.Cryptography.X509Certificates;

namespace _12._String_Equals_Function;

class Program
{
    static void Main(string[] args)
    {
        // //ex1: 
            // string message = "Hello";
            // string compare = "Hello";

            // if (message == compare)
            // {
            //     Console.WriteLine("The strings are same");
            // }
            // else
            
            // {
            //     Console.WriteLine("The strings are different");
            // }

        // ex2:
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("The strings are same");
            }
            else
            
            {
                Console.WriteLine("The strings are different");
            }

        // ex3:
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            //if (name != "")
            if(!name.Equals(""))
            {
                System.Console.WriteLine($" your name is {name }");
            }
            else
            {
                System.Console.WriteLine("You didn't enter your name"); 
            }


        
        Console.ReadLine();

    }
}
