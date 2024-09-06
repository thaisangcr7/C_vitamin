using System.Runtime.InteropServices;
//using System.Runtime.InteropServices.OptionalAttribute;


namespace _29._Optional_Parameters
{
class Program
{
    static void Main(string[] args)
        {
            // call the function Add
            int result = Add(5);
            System.Console.WriteLine(result);

            // Test default function
            PrintName();
            PrintName("John");

            Console.ReadLine();
        }

        // Create Add funciton
            static int Add(int a, int b = default) // using default for optional parameter
            {
                return a + b;
            }
            //
            //     static int Addw(int a, [Optional]int b = default) // using default for optional parameter
            // {
            //     return a + b;
            // }


        // Use case - if no string put in PrintName() then = SangT as default
            static void PrintName(string name_1 = "SangT")
            {
                System.Console.WriteLine($"My name is {name_1}");
            }

}
}
