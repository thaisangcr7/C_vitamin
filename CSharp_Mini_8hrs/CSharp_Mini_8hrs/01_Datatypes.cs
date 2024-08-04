    namespace CSharp_Mini_8hrs;

    public class _01_Datatypes

    {
        public void Run()
        {
        
        // example of some datatype operation

        int number = 10;
        string text = "sanple text";

        Console.WriteLine("Number:" + number);
        Console.WriteLine("Text: " + text);

        // register as an interger
        int age = 23;
        Console.WriteLine(age);
        System.Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(long.MinValue);

        // register as a L at the end to processs it as a Long 
        long bignumber = 90000000L;
        System.Console.WriteLine(bignumber);
        System.Console.WriteLine(long.MaxValue);
        System.Console.WriteLine(long.MinValue);

        // Double - D at the end to processs it as a Double 
        Double negative = -55.2D;
        System.Console.WriteLine(negative);
        System.Console.WriteLine(double.MaxValue);
        System.Console.WriteLine(double.MinValue);

        // Float
        float precision = 5.00001F; 
        System.Console.WriteLine(precision);
        System.Console.WriteLine(float.MaxValue);
        System.Console.WriteLine(float.MinValue);

        // Decimal 
        decimal money = 14.99m;
        System.Console.WriteLine(money);
        System.Console.WriteLine(decimal.MaxValue);
        System.Console.WriteLine(decimal.MinValue);

        }
    }

