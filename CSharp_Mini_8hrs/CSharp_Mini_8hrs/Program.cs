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

            Console.WriteLine("Let's get some C, Sang");
            // Keep console open until a key is pressed
            Console.ReadLine();           

        }
    }
}

