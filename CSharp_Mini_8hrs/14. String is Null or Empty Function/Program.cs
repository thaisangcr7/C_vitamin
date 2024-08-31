namespace _14._String_is_Null_or_Empty_Function;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine($" Your name is {name}");

        //
        // Check if the string is null or empty
            // if (name != "")
            //      System.Console.WriteLine("0");  

            // if (!name.Equals(""))
                // System.Console.WriteLine("1");


        // if the string is null or empty then print 2 
            if(!string.IsNullOrEmpty(name))
            System.Console.WriteLine("2");
            
 
        Console.ReadLine();  
    }
}
