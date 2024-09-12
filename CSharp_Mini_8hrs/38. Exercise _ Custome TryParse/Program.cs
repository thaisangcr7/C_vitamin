namespace _38._Exercise___Custome_TryParse;

class Program
{
    /*
    * Create a int and try convert any string to an int
    * Notice the error, write a try...catch handler around it
    * Catch the error and output the error message
    * without changing the current code
    *

    * Why is this a bad situation and how can we know if its been converted?
    *
    * Create a custome try parse function
    * Find the real function and copy return type/params
    * Read the tooltip it gives you, to give you ideas on what to do


    */
    static void Main(string[] args)
    {
        // bool success = false;
        //     try
        //     {
        //     System.Console.WriteLine("Enter your number: ");
        //     int num = Convert.ToInt32(Console.ReadLine());
        //     success = true;
        //     }
        //     catch (FormatException e)
        //     {
        //         System.Console.WriteLine(e.Message);
        //     }
        // System.Console.WriteLine(success? "Yey" : "Oh No");

        System.Console.WriteLine("Enter a number: ");
        if (TryParse(System.Console.ReadLine(), out int result))
        {
            System.Console.WriteLine("yey " + result);
        }
        else
        {
            System.Console.WriteLine("oh no");
        }

        Console.ReadLine();

    }

        static bool TryParse(string input, out int result)
        {
             result = -1;
             try
             {
                result = Convert.ToInt32(input);
                return true;
             }
             catch (Exception)
             {
                return false;
             }

        }


}
