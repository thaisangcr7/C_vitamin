
using System;
using System.Collections.Generic;
using System.Text;

namespace C_vitamin_p1
{
    public class FizzBuzz
    {
        /// <summary>
        /// From numbers from 1 to num: 
        /// Print Fizz if its divisible by 3.
        /// Print Buzz if its divisible by 5.
        // 1, 2, fizz, 4, buzz, fizz/// 
        /// Print FizzBuzz if divisible by both 3 and 5.
        /// Print the number itself if not divisble by 3 or 5.
        /// Return a list of strings with all values from 1 to n.
        /// </summary>
        /// <param name="num">Should take in n which is an integer</param>
        public void Run(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 != 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                // Print FizzBuzz if its divisible by 15
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                // Print the number itself
                else
                {
                    Console.WriteLine(i);
                }

            }
            
            // Print Buzz if divisible by 5
            Console.Read();
        }
    }
}

