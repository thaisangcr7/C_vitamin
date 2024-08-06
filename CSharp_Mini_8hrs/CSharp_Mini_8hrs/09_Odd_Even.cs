using System;
using System.Collections.Concurrent;

namespace CSharp_Mini_8hrs
    
{
    public class _09_Odd_Even
    {
        public void run()
        {

            /* 
            Create & initalise two ints
            Make a variable to work out the remainder
            Output remainder to the screen
            Change the first int variable to aother number
                And recalculate the remainder
                Output new remainder to the screen
            */
            
            int num1 = 10;
            int num2 = 2;
            int remainder = num1 % num2;
            System.Console.WriteLine(remainder); // 0 is even

            int num3 = 11;
            int num4 = 2;
            int remainder1 = num3 % num4;
            System.Console.WriteLine(remainder1); // 1 is odd

        }
            
    }

}

