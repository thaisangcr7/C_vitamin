using System;
using System.Collections.Concurrent;

namespace CSharp_Mini_8hrs
    
{
    public class _05_Modulus
    {
        public void run()
        {
            
            // 10/3 = 3r1
            // 10 % 3 = 1
            // 3 * 3 = 9, 1 left over to get to 10
            // 11 % 2 = 1
            // 12 % 2 = 0
            // 13 % 2 = 1
            // 1000 % 90 = 10
            // 100 % 90 = 10
            // 71 % 90 = 1
            int firstNum = 10;
            int secondNum = 3;
            System.Console.WriteLine(firstNum % secondNum);
            System.Console.WriteLine(1000 % 90);
            System.Console.WriteLine(100 % 90);
            System.Console.WriteLine(71 % 90);


        }
    }

}

