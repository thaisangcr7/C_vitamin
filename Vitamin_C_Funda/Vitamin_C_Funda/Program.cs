using System;
using System.Security.Cryptography.X509Certificates;
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

            // Enum
            // Enum Enum_employeetypes = new Enum();
            // Enum_employeetypes.run();
            //9 Array List
            _9_Arrays_Lists Arrays_Lists = new _9_Arrays_Lists();
            Arrays_Lists.Arrays_Lists_run();

            int[] sampleArray1 = new int[5];
            int[] sampleArray2 = new int[5]{1,2,3,4,5};
            System.Console.WriteLine("How many employees IDs do you want to register?");
            int length = int.Parse(Console.ReadLine()); 
            int[] employeeIds = new int[length];
            var testId = employeeIds[0];

            // get value inside  the arrays
            // for (int i = 0; i < length; i++)
            // {
            //     System.Console.WriteLine("Enter employee ID: ");
            //     int id = int.Parse(Console.ReadLine()); // assume here that the user will 
            //     //always enter an int value
            //     employeeIds[i] = id;
            // }
            // for (int i = 0; i < employeeIds.Length; i++)
            // {
            //     System.Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
            // }

            //
         
            Console.ReadLine();   


            // // Types in .Net
            // 1. Class
            // 2. Struct
            // 3. Interface
            // 4. Enumeration
            // 5. Delegate

            /*
            Value Types (Enumerations & Structs)
            Reference Types (Classes, Interfaces & Delegates)
            */
        }

    }
}