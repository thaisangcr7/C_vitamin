namespace _15._Excercise___Print_String_in_Reverse;

class Program
{
    static void Main(string[] args)
    {
        // Ask user to input message
        // print in order
        // print in reverse
        Console.Write("Enter Your message: ");
        string message = Console.ReadLine();

        // check the length; 
            //System.Console.WriteLine(message.Length); // result: 14 = 0-13 index
        // print in order
        for (int i = 0; i < message.Length; i++) // go from 0-13
        {
             System.Console.WriteLine(message[i]);
        }

        Console.WriteLine(); // seperate line

        // print in reverse
        for (int s = message.Length -1; s < message.Length; s--)
        {
            System.Console.WriteLine(message[s]);
        }

        



        Console.ReadLine();
    }
}
