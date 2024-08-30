namespace _7._Excercise___Times_Table;

class Program
{
    static void Main(string[] args)
    {
        /* 
            Ask The User for a number for the table
            Write a for loop to print X times table
        */

        System.Console.WriteLine("Enter a Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter a Number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 10; i ++)
        {
            // {0} x {1} x {2} = {3} = 0 is i, 1 is number, 2 is number2, 3 is our mutiple
            // Those inside curly bracket called placeholders
            System.Console.WriteLine("{0} x {1} x {2} = {3}", i, number, number2, i * number * number2);
        }

        Console.ReadLine();


    }
}
