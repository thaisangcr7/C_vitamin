namespace _27._Return_Type_Functions;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = $"{ReturnName()} - {ReturnAge()}";
        PrintIntroduction();

        
    }

    // instead of void using string 
    static string ReturnName()
    {
        return "SangT";
    }

    static int ReturnAge()
    {
        return 27;
    }
    static void PrintIntroduction()
    {
            System.Console.WriteLine(ReturnName());
    }
        

}

