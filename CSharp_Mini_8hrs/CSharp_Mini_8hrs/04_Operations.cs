using System;
using System.Collections.Concurrent;

namespace CSharp_Mini_8hrs
    
{
    public class _04_Operations
    {
        public void run()
        {
        
            int age = 23;

            // incremental by 1
            age ++;
            System.Console.WriteLine(age);

            // decremental by 1
            age--;
            System.Console.WriteLine(age);

            // age = age + 10
            age = age + 10;
            System.Console.WriteLine(age);

            age += 10;
            System.Console.WriteLine(age);                      

            age -= 10;
            System.Console.WriteLine(age);

            String name = "Sang ";
            name += "is programing to get more Vitamin Csharp";
            System.Console.WriteLine(name);

            int i = 0;
            System.Console.WriteLine(++i);
            System.Console.WriteLine(i);


        }
    }

}

