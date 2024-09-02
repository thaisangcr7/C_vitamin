using System;

namespace Inheritance;


        // the Italian can makes everthing and can also do another stuffs as well 
        // use Inheritance 
        // note: the ItalianChef inherted everything from Chelf class 
        // with : Chef -- the ItalianChef can do everthing the Chef do
public class ItalianChef : Chef
    {

        // this ItalianChef can also make Pasta
        public void MakePasta()
        {
            Console.WriteLine(" The Italian Chef is making Pasta");
        }
        // Override MakeSpecialDish 
        public override void MakeSpacialDish()
        {
            System.Console.WriteLine(" The Italian makes Pho Tai bo vien for special dish");
        }



    }
