namespace _21._Array_IndexOf;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            90, 11, 22,11, 33
        };

        Console.Write("Enter number to search: ");
        int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(numbers, search, 0, 2); search from 0 to 2 
            // //int position = Array.IndexOf(numbers, search, 2); search from index number 2 and upward
            int position = Array.IndexOf(numbers, search);

            if (position > -1)
            {
                System.Console.WriteLine($" Number {search} has been found at position {position +1}");
            }
            else
            {
                Console.WriteLine("Numnber has not been found");
            }

            // =====

            // int position = -1;
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     if(numbers[i] == search)
            //     {
            //         position = i;
            //     }
            // }
            // if (position > -1) // 0 => 1
            // {
            //     System.Console.WriteLine($" Number {search} has been found at position {position +1}");
            // }
            // else
            // {
            //     Console.WriteLine($"Numnber {search} has not been found");
            // }

    }
}
