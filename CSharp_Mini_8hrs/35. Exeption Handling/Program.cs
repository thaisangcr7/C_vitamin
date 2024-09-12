namespace _35._Exeption_Handling;

class Program
{
    static void Main(string[] args)
    {
        // how to handle exception when user put in wrong inputs
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(number);

        Console.ReadLine();
    }
}
