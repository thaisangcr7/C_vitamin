using System;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;
using System.Transactions;

namespace CSharp_Mini_8hrs
    
{
    public class _11_If_Statement
    {
        public void run()
        {
        
        // If Statement
            // Prompt the user to enter their name
            // Read the user's input and store it in a string variable called name
            Console.Write("Enter your name here: ");
            string? name = Console.ReadLine();
            
            // Prompt the user to enter their age
            // Read the user's input and store it in a string variable called ageInput
            // Declare an integer variable called age to store the parsed age input
            Console.Write("Enter your age: ");
            string? AgeIntput = Console.ReadLine();
            int age;

            // Use int.TryParse to attempt to parse the age input as an integer
            // If the input is not a valid integer, print an error message and exit the method
            // Print an error message if the input is not a valid integer
                // int.TryParse is a method that attempts to convert a string to an integer.
                // AgeIntput the string to be converted (in this case, the user's age input)
                // out age the variable to store the result of the conversion (in this case, the user)
                // out keyword means that the method will modify the value of `age`.
            if(!int.TryParse(AgeIntput, out age)) 
                {
                    Console.WriteLine("Invalid age input. Please enter a valid integer.");
                    Console.Write("Enter your age: ");
                    AgeIntput = Console.ReadLine();
                }

            // Print a blank line to separate the input from the output
             // Use string interpolation to print a message with the user's name and age
            System.Console.WriteLine();
            System.Console.WriteLine($" Your name is {name}+ Your age is  {age}");

        


        }
            
    }

}

