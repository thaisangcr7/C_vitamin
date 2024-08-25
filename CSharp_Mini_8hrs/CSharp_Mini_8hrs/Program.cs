using System;

namespace CSharp_Mini_8hrs
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01 Create a new instance of the _01_Datatypes class
            _01_Datatypes datatype = new _01_Datatypes();
            datatype.Run(); // Runs the demonstration of data types

            // 02 Create a new instance of the _02_ConvertingStringToNumbe}rs class
            _02_ConvertingStringToNumbers conv = new _02_ConvertingStringToNumbers();
            conv.run(); // Runs the demonstration of string-to-number conversion

            // 03 Boolean 
            _03_Bool bools = new _03_Bool();
            bools.run();

            // 04 Operations
            _04_Operations Operations = new _04_Operations();
            Operations.run();

            // 05 Modulus
            _05_Modulus modulus = new _05_Modulus();
            modulus.run();

            // 06 VarKeyWord
            _06_VarKeyword varkeyword = new _06_VarKeyword();
            varkeyword.run();

            // 07 Constant
            _07_constant constant = new _07_constant();
            constant.run();

            // 08 Storing User Data _ Excercise
            _08_StoringUserData_Exercise storinguserdata = new _08_StoringUserData_Exercise();
            storinguserdata.run();

            // 09 Odd and Even Checker
            _09_Odd_Even OddEven = new _09_Odd_Even();
            OddEven.run();

            // 10 Console Input and Oupt
            _10_Console_InputOutput inputOutput = new _10_Console_InputOutput();
            inputOutput.run();

            // 11 If Statement
            _11_If_Statement if_Statement = new _11_If_Statement();
            if_Statement.run();

            


            Console.WriteLine("Let's get some C, Sang");
            // Keep console open until a key is pressed
            Console.ReadLine();           

        }
    }
}

