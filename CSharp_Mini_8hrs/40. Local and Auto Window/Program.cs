namespace _40._Local_and_Auto_Window;

class Program
{
    static void Main(string[] args)
    {
        // int age = 35;

        // if (age > 18)
        // {
        //     Console.WriteLine("18+");
        // }
        // else if (age > 30)
        // {
        //     Console.WriteLine("30+");
        // }

        string name = "Aba";
        int age;
        age = 23;

         

        string message = ReadFromConsole("Enter anything: ");
        System.Console.WriteLine(message);

        Console.ReadLine();
    }

    static void PrintDetails(string name,int age)
    {
        System.Console.WriteLine($"{name} - {age}");
        System.Console.WriteLine($"{name} - {age}");
        System.Console.WriteLine($"{name} - {age}");
    }

    static string ReadFromConsole(string message)
    {
        System.Console.WriteLine(message);
        return System.Console.ReadLine();
    }
}
