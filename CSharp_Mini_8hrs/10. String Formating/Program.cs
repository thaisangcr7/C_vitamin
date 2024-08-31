namespace _10._String_Formating;

class Program
{
    static void Main(string[] args)
    {
        string name = "Aba";
        int age = 25;

        System.Console.WriteLine("Name " + name);
        System.Console.WriteLine("Age " + age);

        System.Console.WriteLine();

        System.Console.WriteLine("Name: " + name + "\nAge: " + age);

        System.Console.WriteLine(" Your name is " + name + " , and your age is " + age);

        // Better Formatting
        System.Console.WriteLine(" Your name is {0}, and your age is {1}", name, age); // better formating     

        System.Console.WriteLine("Name: {0}\nAge: {1}", name, age);

        // String Interpolation
        System.Console.WriteLine($"Your name is {name}, and your age is {age}");

        // Emty String  
            System.Console.WriteLine("Enter your name: ");
            string? nameEmptyTest = Console.ReadLine();

            if (name != string.Empty) // ""
            {
                System.Console.WriteLine($" Your name is {nameEmptyTest}");
            }  
            else
            {
                System.Console.WriteLine("Name is Empty");
            }

            Console.ReadLine();





    }
}
