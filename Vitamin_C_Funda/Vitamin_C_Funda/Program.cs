using System;
using System.Text;

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

            // section 6
            _6_String workingWithString = new _6_String();
            workingWithString.run();

            // Section 7 -- 
            // C# alwayes use constructors to generate a new object
            // _7_Creating_Classes_Objects is variable type
            // _7_Creating_Classes_Objects Creating_Classess_Objects is create variable
            // creating_classess_object is a varibale name, "=" is the assignment operator, 
            // new _7_Creating_Classes_Objects() is creating object;
            _7_Creating_Classes_Objects Creating_Classess_Objects  = new _7_Creating_Classes_Objects();
            Creating_Classess_Objects.Performwork();

            // section 8
            _08_Value_Reference_types ValueReferenceTypes = new _08_Value_Reference_types();
            // ValueReferenceTypes.ReferenceTypes();
            // ValueReferenceTypes.runStringBuilder();

            

            Console.WriteLine("Let's get some C, Sang");

            //
            System.Console.WriteLine("Creating an employee");
            System.Console.WriteLine("------------------\n");

            string name = "bethany";
            string anotherName = name;
            name += " smith";
            System.Console.WriteLine($"Name: {name}");
            System.Console.WriteLine($"AnotherName: {anotherName}");
            string upperCaseName = name.ToUpper();
            System.Console.WriteLine($"Upper Name: {upperCaseName}");

            string firstName4 = "Bethany";
            string lastName4 = "Smith";
            StringBuilder builder = new StringBuilder();
            builder.Append("lastname: ");
            builder.AppendLine(lastName4);
            builder.Append("First Name: ");
            builder.AppendLine(firstName4);
            string result = builder.ToString();
            System.Console.WriteLine(result);


            StringBuilder builder2 = new StringBuilder();

            for (int i = 0; i < 10; i ++)
            {
                builder2.Append(i);
                builder2.Append(" ");
            }
            string listtest = builder2.ToString();
            System.Console.WriteLine(listtest); 




            Console.ReadLine();   

        }
    }
}