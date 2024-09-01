namespace _18._Arrays_Sorting;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            9, 4, 6, 4, 5,6, 7, 8, 9
        };

        Array.Sort(numbers);

        foreach (int num in numbers)
        {
            Console.Write($"  {num}");
        }

        Console.ReadLine();


    }
}
