using System;
using System.ComponentModel;
using System.Runtime.Serialization;
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

                /*
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


                // Relational Operations
                // Evaluating if 'age1' is greater than or equal to 18 AND 'age2' is less than or equal to 65
                // Since 'age1' is less than 18, the entire expression will be False
                // Evaluating if 'age1' is greater than or equal to 18 OR 'age2' is less than or equal to 65
                // Since 'age2' is less than 65, the entire expression will be True
                int age1 = 16;
                int age2 = 64;
                bool d = (age1 >= 18) && (age2 <= 65);
                Console.WriteLine("Age1 is greater than 18 AND age2 is less than 65: " + d);
                bool e = (age1 >= 18) || (age2 <= 65);
                Console.WriteLine("Age1 is greater than 18 OR age2 is less than 65: " + e);
                */

                /*
                //  If Statement
                
                Console.WriteLine("Enter the age of the new candidate: ");
                string? input = Console.ReadLine();
                    {
                    //Try to parse the input into an integer
                    if (int.TryParse(input, out int age))
                    //int age = int.Parse(Console.Read())

                        if (age < 18)
                            {
                            System.Console.WriteLine(" Too young to apply for job");
                            System.Console.WriteLine(" Send email to candidate");
                            }
                        else if (age > 65)
                            {
                            System.Console.WriteLine(" Too old to apply for job");
                            System.Console.WriteLine(" Send email to candidate");
                            }
                        else
                            {
                            System.Console.WriteLine(" Candidate is eligible for the job");
                            }
                    }
                    */
            // Switch Statement
            /*
            Switch(expression)
            {
                case costant expression 1:
                // other statements
                break;
                Case realtional expression 2:
                // other statements
                break;
                ...
                default:
                // other statements
                break;
            }
            */
            switch (age)
            {
                case int n when n < 18:
                Console.WriteLine("Too young to apply for job");
                Console.WriteLine("Send email to candidate");
                break;
                case int n when n > 65:
                Console.WriteLine("Too old to apply for job");
                Console.WriteLine("Send email to candidate");
                break;
                case int n when n == 42:
                default:
                Console.WriteLine("Candidate is eligible for the job");
                break;

            }


                Console.ReadLine();

            }

        }
}
