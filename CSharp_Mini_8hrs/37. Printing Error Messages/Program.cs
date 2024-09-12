namespace _37._Printing_Error_Messages;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
        }
        catch (System.Exception e)
        {
            
            System.Console.WriteLine($"error: {e.Message}");
        }
    }
}
