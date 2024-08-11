using System;

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


// Relational Operations ------------------
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
//  If Statement------------------------
                
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
// Switch Statement--------------------
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
            /*
            // Switch Statement Example 
            // note: Swtich works with most of data types, but not Float and double
            
            int age = 25;
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
            */

// Iterations: -----------------------
            //continue executing a task(looping)
            // often used in combination with counter
            // ask input until stop is reached
            // keep reading files from disk
            // 1. For Loop: continue executing a task(looping)
            // 2. While Loop: continue executing a task(looping) until a condition is met
            // 3. Do-while

            // Excercise:
            /*
// while loop ----------------------
            // Asking user to enter a value
            Console.WriteLine("Enter a value: ");
            string? input = Console.ReadLine();

            //Try to parse the input into an integer
            if (int.TryParse(input, out int max))
            
            {
                int i = 0;
                while (i < max)
                {
                    Console.WriteLine(i);
                    i++;
                }
                Console.WriteLine("Loop finishes");
            }

            */
            /*
// Switch with While Loop
            Console.WriteLine("choose the action you want to do: ");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. update employee");
            Console.WriteLine("3. delete employee");
            Console.WriteLine("99. Exit application");

            string? selectionAction = System.Console.ReadLine();

            while (selectionAction != "99")
            {
                switch (selectionAction)
                {
                    case "1":
                    Console.WriteLine("Add employee");
                    break;
                    case "2":
                    Console.WriteLine("update employee");
                    break;
                    case "3":
                    Console.WriteLine("3. delete employee");
                    break;
                    default:
                    System.Console.WriteLine("invalid input");
                    break;
                }
                Console.WriteLine("choose the action you want to do: ");
                Console.WriteLine("1. Add employee");
                Console.WriteLine("2. update employee");
                Console.WriteLine("3. delete employee");
                Console.WriteLine("99. Exit application");
                selectionAction = System.Console.ReadLine();
            }
                Console.WriteLine("Closing Application");
            */
            
            /* //
// While Loop - nested loop
// Nested While Loop Example
// =========================
// This code will print the values of two counters, i and j, to the console.
// The outer loop will iterate 10 times, and for each iteration, the inner loop will iterate 10 times.
            // Initialize counters
            int i = 0; // outer loop counter
            int j = 0; // inner loop counter
        
            // Outer loop
            while (i <10)
                {
                    // Inner loop
                    while (j<10) // loop will interate 10 times for each outer loop interation
                    {
                        // Print current values of i and j to console
                        Console.WriteLine("i: " + i + " j: " + j);
                        j++; // increment inner loop counter
                    }
                    j = 0; // reset inner loop counter for next outer loop iteration
                    i++; // increment outer loop counter
                }    
                */
                // while (true)
                // {
                //     System.Console.WriteLine(DateTime.Now);
                // }

// Create do do while loop
// ======================
                // int i = 0;
                // do 
                // {
                //     System.Console.WriteLine(i);
                //     i++;
                // }
                // while (i<5);
/*
// example 
// if it is 99 do not go through the switch, if we find a match then go into the switch ()
// if we do not find a match then go into the default
// switch (selectionAction)
                string? selectedAction = Console.ReadLine();
                do 
                {
                    Console.WriteLine("choose the action you want to do: ");
                    Console.WriteLine("1. Add employee");
                    Console.WriteLine("2. update employee");
                    Console.WriteLine("3. delete employee");
                    Console.WriteLine("99. Exit application");
                    
                    selectedAction = Console.ReadLine();

                    switch (selectedAction)
                        {
                            case "1":
                            // Add employee
                            Console.WriteLine("Enter employee name:");
                            break;
                            case "2":
                            // update employee
                            Console.WriteLine("Enter employee name:");
                            break;
                            case "3":
                            // delete employee
                            Console.WriteLine("Enter employee name:");
                            break;
                            case "99":
                            // Exit application
                            Console.WriteLine("Exiting application");
                            break;
                            default:
                            // if we do not find a match then go into the default
                            Console.WriteLine("Invalid choice");
                            break;
                        }
                } while (selectedAction != "99");
                        
*/
/*
// For loop
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine(i);
// }
// For each loop
// int[] numbers = { 1, 2, 3, 4, 5
// };

                // For Loop
                // for (int i =0; i < 10; i += 2)
                // {
                //     Console.WriteLine(i);
                // }
                //
                // for (int i = 0; i < 10; i++)
                // {
                //     System.Console.WriteLine(i);
                // }
                
                System.Console.WriteLine("Enter a value: ");
                int max = int.Parse(Console.ReadLine());

                for (int i = 0; i < max; i++)
                {
                    if (i ==5)
                        {
                        System.Console.WriteLine("Bingo! " + i + " was found!");
                        continue;
                        }
                    System.Console.WriteLine(i);
                }    
*/



 //               Console.ReadLine();

            }

        }
}