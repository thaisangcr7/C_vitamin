namespace _19._Array_Reversal;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            0,1,2,4,3,2,3,5,4
        };

        Array.Reverse(numbers);

        foreach (int num in numbers)
        {
            Console.Write($" {num}");
        }

        Console.ReadLine();
    }
}
