using System.Globalization;

namespace _34._Exercise___Sum_of_Int_Array;

class Program
{
    // Create and initialise int array of numbers
    // Create function SumofNumbers with int retun type
    // Int array param
    // Funcrion should retun total of all numbers
    // Call in main and output the total
        // Extra: Check array length
        // return -1 if array empty
        // check return in main and output message
        // do we need to retun -1, how else can we make this?
    static void Main(string[] args)
    {
        //1.  Create and intialise array
        int[] numbers = new int[]
        {
            0,1,2,3,4,5
        };

        // 3. Call the number array
        System.Console.WriteLine(SumofNumbers(numbers));
        
    }

        // 2. Create function - SumofNumbers to call an array
        static int SumofNumbers(int[] numbers)
        {
            int total = 0;

            // create a for loop - to go through an array
            foreach (int item in numbers)
            {
                total += item;
            }

            return total;

        }
}
