using System;
using System.Security.Cryptography.X509Certificates;


namespace Vitamin_C_Funda
{
    public class _5_Using_Methods
    {

        public void run()

        {
                /*
                1. Understand methods
                2. Adding a helper file
                3. Finding the correct method
                4. Understanding varibale scope
                5. More options with methods
                6. Introduction the main method
               */ 

               // 1. Understand methods
               // Methods are blocks of code that can be called multiple times from different parts of the program.
               // They can take arguments and return values.
               // Methods are useful for organizing code, reducing repetition, and improving readability.
                // Code Block
                // Recieves parameters and (optionally) returns value
                // Readable code and code resuse
                // Decleared within a class or struct

                // C# Method Syntax
                // <access modifier> <return type> method_name (parameters)
                // { Method statements}
                // exxample:

                // int amount = 2000;
                // int months = 12;
                
            
                // CalculationYearlyWage(amount, months);
                // Console.ReadLine();
                // static void CalculationYearlyWage(int monthlyWage, int numberofmonthworked)
                // { 
                //     System.Console.WriteLine($"Yearly wage: {monthlyWage * numberofmonthworked}");
                // }
                // exxample:
/*
                int amount = 2000;
                int months = 12;

                int YearlyWage = CalculationYearlyWage(amount, months);
                
                Console.WriteLine($"Yearly wage: {YearlyWage}");
                Console.ReadLine();
                static int CalculationYearlyWage(int monthlyWage, int numberofmonthworked)
                { 
                    //System.Console.WriteLine($"Yearly wage: {monthlyWage * numberofmonthworked}");
                    // retun montlyWage * numberofmonthworked;
                    if(numberofmonthworked ==12) // let add a bonus month
                        return monthlyWage * (numberofmonthworked +1);
                    return monthlyWage * numberofmonthworked;
                }
   */
                //static int CalculationYearlyWageExpresssionBodied(int montlyWage, int numberofmonthworked, int bonus) => monthlyWage * numberofmonthworked + bonus;          

                // Console.ReadLine();

                // 2. Adding a helper file


        }
    }
}