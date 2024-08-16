using System;
using System.Security.Cryptography.X509Certificates;

namespace Vitamin_C_Funda
{
    
public class _08_Value_Reference_types
    {
        public void run()
        {
            string a = "hello";
            string b;
            b = a;
            b += " world";
            System.Console.WriteLine(a);

            Console.ReadLine();
        

        }

    }
}

