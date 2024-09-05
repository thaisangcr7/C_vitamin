using System.Globalization;

namespace _27._Return_Type_Functions;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = $"{ReturnName()} - {ReturnAge()}";
        PrintIntroduction();


        int[]numbers = new int[3];

        // you can do the mannual step to ask user enter the input 
        // Console.Writeline("Enter your number: ");
        // numbers[0] = Convert.ToInt32(Console.Readline());
        // Console.Writeline("Enter your number: ");
        // numbers[1] = Convert.ToInt32(Console.Readline());
        // Console.Writeline("Enter your number: ");
        // numbers[2] = Convert.ToInt32(Console.Readline());

        // or use the for loop 
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadNumberFromConsole(); // call the function
        }

        foreach (int item in numbers)
        {
            System.Console.Write($" {item}");
        }

        // call the CreateRandom Array
        int[] NewNumbers = CreateRandomArray();

        foreach (int s in NewNumbers)
        {
            System.Console.Write($" {s}");
        }

        Console.ReadLine();
    }

        static void test()
        {
            // conversion
            // calcualtion
        }

    // make it shorter to return 
        static int ReadNumberFromConsole()
        {
            System.Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

    //Create a random array function
        static int[] CreateRandomArray()
        {
            
            return new int[3] {0,1,4};

            // longer steps
            // int[] numbers = new int[3]
            // {
            //     0, 1, 4
            // };
            // return numbers;
        }


    // instead of void using string 
        static string ReturnName()
        {
            return "SangT";
        }

        static int ReturnAge()
        {
            return 27;
        }
        static void PrintIntroduction() 
        {
                // System.Console.WriteLine(ReturnName());
                // string name = ReturnName();
                // int age = ReturnAge();
                // string output = $"HEllo! My name is {name} and My age is {age}  ";
                // Console.WriteLine(output); 

                // Call the function 
                System.Console.WriteLine($"HEllo! My name is {ReturnName()} and My age is {ReturnAge()}  ");;
        }

    // Best practice is to have diffrent functions seperately for ex: 1 convert and 1 calculation

        // 
        static int Add()
        {
            int.TryParse("", out int x);
            return x;
        }

        static bool TryParse(string s, out int Result)
        {
            Result = 0;
            return true;
        }



   
        

}

