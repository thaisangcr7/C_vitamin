using System;
using System.Security.AccessControl;
using System.Security.Cryptography;


namespace Vitamin_C_Funda
{
    public class _4_Decision_Iteration_Statements

        {
            public void run()
            {
                // wotking with Boolean Values
                // Making decisions with the if statemments
                // Using the switch statement
                // Adding Iterations

                // Declaring an integer variable 'age' and assigning it a value of 23
                int age = 23;

                // Evaluating if the 'age' is equal to 23 and storing the result in a boolean variable 'a'
                bool a = age == 23;
                Console.WriteLine("Age is 23: "+a); // Output: True

                // Evaluating if the 'age' is greater than 23 and storing the result in a boolean variable 'b'
                bool b = age > 23;
                Console.WriteLine("Age is greater than 23: " + b); // false

                // Evaluating if the 'age' is between 18 and 65 (inclusive) and storing the result in a boolean variable 'c'
                bool c = (age >= 18) && (age <= 65);
                System.Console.WriteLine("Age is between 18 and 65: " + c);

  

                int age1 = 16;
                int age2 = 64;
                bool d = (age1 >= 18) && (age2 <= 65);
                Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
                bool e = (age1 >= 18) || (age2 <= 65);
                Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);

                Console.ReadLine();

            }

        }
}
