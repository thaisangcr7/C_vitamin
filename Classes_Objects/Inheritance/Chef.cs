using System;

namespace Inheritance;

public class Chef
    {
        // method 1 
        public void Makechicken()
        {
            System.Console.WriteLine(" The Chef makes chicken");
        }
        
        // method 2 
        public void MakeSalad()
        {
            System.Console.WriteLine(" The Chef makes salad");
        }
        
        // method 3
        // virtual means that it the method can be overriden in any subclass in this case is ItalianChef
        public virtual void MakeSpacialDish()
        {
            System.Console.WriteLine(" The Chef makes bbq ribs");
        }

    }
