namespace _16._Exercise___Password_Checker;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sang - You are on your way to be the developer");
        /* // ex1: Problem
        Ask user to enter password, and store
        Ask user to enter password again, and store
        Check if they are both contain something
            if so check if they are the same
                If they are, Print "Passwords match"
                If they are not, Print "Passwords do not match"
            If they are empty, Print " please enter a password."
        */

        // Begin Work:
        
            Console.WriteLine("Enter you password 1: ");
            string password1 = Console.ReadLine();
            Console.WriteLine("Enter you password 2: ");
            string password2 = Console.ReadLine();

            // if not empty
                // then check if they are the same - if the same print match
                // if not the same then print  - if nor the same print do not match
            // else (if empty) then ask user for password again

            // Sang codes are below: 
                if (password1 != "" && password2 != "")
                {
                    if (password1 ==password2)
                    {
                        System.Console.WriteLine(" PW match");
                    }
                    else
                    {
                        Console.WriteLine("Pw is not match");
                    }
                }
                else
                {
                    System.Console.WriteLine("Please re-Enter your passwords again");
                }
            
            // CoffeeNCode are below:
                // if (!password1.Equals(string.Empty) && !password2.Equals(string.Empty))   
                // {
                //     // make a restriction on lengeth
                //     if (password1.Length >= 6 && password2.Length >=6)
                //         {
                //             if(password1.Equals(password2))
                //             {
                //                 System.Console.WriteLine(" PW match");
                //             }
                //             else
                //             {
                //                 System.Console.WriteLine("Pw is not match");
                //             }
                //         }
                //     else
                //     {
                //         System.Console.WriteLine("Password must be at least 6 characters long");
                //     }
                // }
                // else
                // {
                //     Console.WriteLine("Please re-Enter your passwords again");
                // }




        //==================  =========  =========  =========  =========  =========    
        /* // ex2: 

        Create a While loop to enter until the user get the right one
        Ask user to enter password, and store
        Ask user to enter password again, and store
        Check if they are both contain something
            if so check if they are the same
                If they are, Print "Passwords match"
                If they are not, Print "Passwords do not match"
            If they are empty, Print " please enter a password."
        */
            // While LOOP 

            string password3, password4;

            // Use a while loop to ensure password3 is not empty
            while (true)
            {
                Console.WriteLine("Enter your password 3: ");
                password3 = Console.ReadLine();

                if (!password3.Equals(string.Empty))
                {
                    break; // exit the loop if password1 is not empty
                }
                else
                {
                    Console.WriteLine("Please enter a password 3.");
                }
            }

            // Use a while loop to ensure password4 is not empty
            while (true)
            {
                Console.WriteLine("Enter your password 4: ");
                password4 = Console.ReadLine();

                if (!password4.Equals(string.Empty))
                {
                    break; // exit the loop if password4 is not empty
                }
                else
                {
                    Console.WriteLine("Please enter a password 4.");
                }
            }

            // Now that we have non-empty passwords, check if they match

             if (!password3.Equals(string.Empty) && !password4.Equals(string.Empty))   
                {
                    // make a restriction on lengeth
                    if (password3.Length >= 6 && password4.Length >=6)
                        {
                            if(password3.Equals(password4))
                            {
                                System.Console.WriteLine(" PW 3 4 match");
                            }
                            else
                            {
                                System.Console.WriteLine("Pw 3 4 is not match");
                            }
                        }
                    else
                    {
                        System.Console.WriteLine("Password must be at least 6 characters long");
                    }
                }
                else
                {
                    Console.WriteLine("Please re-Enter your passwords again");
                }


    }
}
