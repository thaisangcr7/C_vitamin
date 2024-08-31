using System.Runtime.InteropServices;

namespace String_Concatenation;

class Program
{
    static void Main(string[] args)
    {
        string name = "Aba";
        int age = 25;

        // String Interpolation
        System.Console.WriteLine($"Your name is {name}, and your age is {age}");

        string test = string.Concat("Your name is ", name, " and your age is ", age);

        // dont have to store it with the varibale 
        System.Console.WriteLine(string.Concat("Your name is ", name, "and your age is ", age));

        // Concatenation with Array 
        // Store strings in an array
        // string[] variable = new string[ ]
        string[]  names = new string[] {"Sang ", "Lien ", " Thu"};

        System.Console.WriteLine(string.Concat(names));

          

        Console.ReadLine();
    }
}
