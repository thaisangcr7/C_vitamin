namespace While_Loops;

class Program
{
    static void Main(string[] args)
    {

        // While Loops
        // print until the condition is True

        // Ex 1 : For Loop
            // for (int i = 0; i <10; i ++)
            // {
            //     Console.WriteLine( i);
            // }

        // Convert the For Loop above into While Loop
        // while condition is true then go into the {}, if false, then exist the While Loop
        // While (Condition)
        // {}

        // ex 1 : While Loop
            // int i = 0;

            // while (i < 10 )
            // {
            //     // i++;
            //     // System.Console.WriteLine(i); // the While Loop will go from 1 to 10 because I+1 = 1 first

            //     // start from 0
            //     System.Console.WriteLine(i);
            //     i++;
            // }
        
        // ex 2:
        // In this example: Enter 2 numbers they guess the result of Modulus, if correct, print well done, else print wrong
        // Request Input NumberA
        // Request Input NumberB
        // NumberA * NumberB
        // Print the result

        // Create a while Loop
        // while condition is true then go into the {}, if false, then exist the While Loop
        // While (Condition)
        // while (answer = actualAnswer )

            Console.WriteLine("Enter the First number");
            string? numAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numAInput);

            Console.WriteLine("Enter the Second number");
            string? numBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numBInput);

            int answer = numberA * numberB; // computer calculate
            int actualAnswer = 0; // innitalize the variable that require user input

            Console.Write("Whats the value of " + numberA + " x " + numberB + " ? ");
            System.Console.WriteLine("");

                while (answer != actualAnswer) // this considtion is True if user enter a wrong answer
                    {
                        string? answerInput = Console.ReadLine(); // ask user Input
                        actualAnswer = Convert.ToInt32(answerInput);

                        {
                            System.Console.WriteLine("Close but it was wrong!");
                        }
                    }
                
                System.Console.WriteLine("Well done!"); 

                // Note: for while Loop
                // because if while condition is true then go inside while loop
                // if while condition is false then exist the while loop and print Well done!
                // keep asking the user for input until they provide the correct answer.

                // 1. User enters an incorrect answer.
                // 2. The while loop condition is true (answer != actualAnswer).
                // 3. The program prints "Close but it was wrong!".
                // 4. The program exits the while loop because the condition is still true.
                // 5. The program prints "Well done!" even though the answer is incorrect.

        // Do WHile loop
            // do { } while (condition)
            // do { } while (answer != actualAnswer)
            // Do will go over everything then check the condition 
                // do
                //     {
                //         string? answerInput = Console.ReadLine(); // ask user Input
                //         actualAnswer = Convert.ToInt32(answerInput);

                //         {
                //             System.Console.WriteLine("Close but it was wrong!");
                //         }
                //     } while (answer != actualAnswer); // this considtion is True if user enter a wrong answer
                
                // System.Console.WriteLine("Well done!"); 


            Console.ReadLine();

         
    }
}
