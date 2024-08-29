namespace _6._TryParse_Function;

class Program
{
    static void Main(string[] args)
    {
        // ex1: 
            // Console.Write(" Enter a number: ");
            // string numInput = Console.ReadLine();
            // //int num = Convert.ToInt32(numInput);

            // //int num1 = 0;
    
            // bool success = int.TryParse(numInput, out int num1);

            // if (success)
            // {
            //     System.Console.WriteLine(num1);
            // }
            // else
            // {
            //     System.Console.WriteLine("Invalid input");
            // }
            // System.Console.WriteLine(num1);


        // Ex2:
            // Initialize a boolean variable to control the loop
            bool success = true;

            // Start a while Loop that continues as long as success is true
            while (success)
            {
                // Print a message asking the user to enter a number
                System.Console.WriteLine(" Enter a number: ");
                // Read the user's input as a string
                string numInput = Console.ReadLine();

                // Attempt to convert the input to an integer using int.TryParse
                if(int.TryParse(numInput, out int num))
                {
                    // If the conversion is successful, set success to false to exit the loop
                    success = false;
                    // Print the successfully converted integer
                    System.Console.WriteLine(num);
                    // Print the successfully converted integer
                    System.Console.WriteLine("Successfully convert to int");
                }
                else
                {
                    // If the conversion fails, print an error message
                    System.Console.WriteLine("Failed to convert!");
                }
            }



        Console.ReadLine();

    }
}
