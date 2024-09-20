using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;


namespace _1.How_To_Make_A_Calculator
{

class Program
{

    // Ask user inputs for num1 and num2
    // Ask them which operator do they want
    // Perform the operation and print the result
    // advance: do a while loop to allow to re-Enter if they anter an incorrect value

    static void Main(string[] args)
    {
        int num1, num2, result = 0;
        string? answer;
      
        
        System.Console.WriteLine("Hello, Let's create calculator");
        
        System.Console.WriteLine("Please Enter Your Number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine("Please Enter Your Number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            System.Console.WriteLine("what type of operation would you like to do?");

            System.Console.WriteLine("Please Enter a for addition,s for subtraction, m for multiplication or d for division.");
            answer = Console.ReadLine();

            if (answer == "a" || answer == "s" || answer == "m" || answer == "d")
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a, s, m or d.");
            }

        }


        if (answer == "a")
        {
            result = num1 + num2;
        }
        else if (answer == "s")
        {
            result = num1 - num2;
        }
        else if (answer == "m")
        {
            result = num1 * num2;
        }
        else if (answer == "d")
        {
            result = num1/num2;
        }
        else
        {
            Console.WriteLine("Invalid operation. Please enter a, s, m, or d.");
        }


        System.Console.WriteLine(result);
        


        
        Console.ReadLine();

    }
}

}
