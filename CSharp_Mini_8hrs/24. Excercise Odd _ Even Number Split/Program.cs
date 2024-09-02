namespace _24._Excercise_Odd___Even_Number_Split;

class Program
{
    static void Main(string[] args)
    {
        // Create two lists with interger data type, one for even numbers, one for odd
        // Loop for from 0-20
            // if number is even, add to even list 
            // if number is odd, add to odd list
        // Print even list
        // Print odd list

        List<int> Even_List = new List<int>();
        List<int > Odd_List = new List<int>();

        // Loop 20 times, if even add to even list, if odd add to odd list
        // even = devisible by 2
        for (int i = 0; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                Even_List.Add(i);
            }
            else
            {
                Odd_List.Add(i);
            }
        }

        // Print Lists
        System.Console.Write("Even List:");
        foreach (int evenNum in Even_List)
        {
            Console.Write($" {evenNum}");
        }
        
        System.Console.Write("\nOdd List:");
        foreach (int oddNum in Odd_List)
        {
            Console.Write($" {oddNum}");
        }

    }
}
