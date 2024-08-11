using System;

namespace Vitamin_C_Funda
{
    class Program
    {
        static void Main(string[] args)

        {
            // section 3
            _3_Learning_C__Syntax syntax = new _3_Learning_C__Syntax();
            syntax.run();

            // section 4 
            _4_Decision_Iteration_Statements statement = new _4_Decision_Iteration_Statements();
            statement.run();
            
            // Section 5
            _5_Using_Methods methods = new _5_Using_Methods();
            methods.run();

            Console.WriteLine("Let's get some C, Sang");
            Console.ReadLine();   

        }
    }
}