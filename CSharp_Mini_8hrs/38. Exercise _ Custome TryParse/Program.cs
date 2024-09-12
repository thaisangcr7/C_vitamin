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
        // First, let's try to convert a string to an int using a try-catch block
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


        // Now, let's use a custom TryParse function to achieve the same result
        System.Console.WriteLine("Enter a number: ");
        if (TryParse(System.Console.ReadLine(), out int result)) // Call our custom TryParse function
        {
            System.Console.WriteLine("yey " + result); // If successful, print the result
        }
        else
        {
            System.Console.WriteLine("oh no");
        }

        Console.ReadLine(); // Wait for the user to press Enter

    }

/*
    * This is our custom TryParse function
    * It takes a string input and tries to convert it to an int
    * If successful, it returns true and sets the out parameter to the result
    * If not successful, it returns false and sets the out parameter to -1
*/
        static bool TryParse(string input, out int result)
        {
             result = -1; // Initialize the out parameter to -1
             try
             {
                result = Convert.ToInt32(input); // Try to convert the input to an int
                return true; // If successful, return true
             }
             catch (Exception)
             {
                return false; // If not successful, return false
             }

        }


}
