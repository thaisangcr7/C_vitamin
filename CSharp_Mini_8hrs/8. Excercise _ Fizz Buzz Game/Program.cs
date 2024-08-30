namespace _8._Excercise___Fizz_Buzz_Game;

class Program
{
    static void Main(string[] args)
    {
        /*
            Create a for loop from 1 to x (15)
            if divisible by 3 and 5 = FizzBuzz
            if divisible by 3 = Fizz
            if divisible by 5 = Buzz
            else = number
        */

        // ex1: 
        //for (intitalize varible, how many time I want to loop, incremental by 1)
        //{}
        // if (condition)
        //{}    
            // for (int i = 0; i <= 15; i++)
            // {
            //     if ( i % 3 == 0 && i % 5 ==0)
            //     {
            //         System.Console.WriteLine("FizzBuzz ");
            //     }
            //     else if (i % 3 ==0)
            //     {
            //         System.Console.WriteLine("Fizz");
            //     } 
            //     else if ( i % 5 ==0)
            //     {
            //         System.Console.WriteLine("Buzz");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }

            //ex 2:
            // better method to save memories BECAUSE we only need to calculate 2 times
            // in C# the the default value of Bool is false
            // in this case we are innitalize the 2 varibale below with bool default
                bool threeDivsible = false;
                bool fiveDevisible = false;

                for (int i = 1; i <= 15; i++)
                {
                    threeDivsible = i % 3 == 0;
                    fiveDevisible = i % 5 == 0;

                    if (threeDivsible && fiveDevisible)
                    {
                        System.Console.WriteLine("FizzBuzz");
                    }
                    else if (threeDivsible)
                    {
                        System.Console.WriteLine("Fizz");
                    }
                    else if (fiveDevisible)
                    {
                        System.Console.WriteLine("Buzz");
                    }
                    else
                    {
                        System.Console.WriteLine("i");
                    }

                }



        Console.ReadLine();
    }
}
