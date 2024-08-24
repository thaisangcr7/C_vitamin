using System;

namespace Static_Methods_Classes;

public class UsefulTools
    {
        // create a method
        // public static SayHi(string name) // this will give the error: Method must have the return type 
        // to solve: add void: voild is not require a return
        public static void SayHi(string name) 
        {
            System.Console.WriteLine(" hello " + name);
        }

    }
