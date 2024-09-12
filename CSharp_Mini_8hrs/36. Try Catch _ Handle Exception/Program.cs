namespace _36._Try_Catch___Handle_Exception;

class Program
{
    static void Main(string[] args)
    {

        // System.FormatException
        // System.OverflowException
        
        // Declare a boolean variable to control the while loop
        bool looping = true;
       
       // Start an infinite loop that will continue until the looping variable is set to false
        while (looping)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(number);
                
                // Set the looping variable to false to exit the loop
                looping = false;

                
            }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number."); 
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Please Enter an number that less than 2 billion");
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Something went wrong");
                } 

        }

        // Print a goodbye message after the loop has finished
        System.Console.WriteLine("Good Bye!");


        Console.ReadLine();
    }
}
