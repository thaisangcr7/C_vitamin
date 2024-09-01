namespace _20._Array_Clearing;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[]
        {
            0,1,2,3,4,5,6,7,8,9
        };

        //Array.Clear(numbers, 0, numbers.Length)
        Array.Clear(numbers, 4, 4);

        for (int i = 0; i < 10; i++)
        {
            numbers[i] = default;
        }


        foreach (var num in numbers)
        {
            Console.Write($" {num}");
        }

    }
}
