namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        // Inhetitance
        // Inheritance is a technique that we can have 1 class that inherited all the functionality of another classes 
        // I can create a supper class that are going to inherit all the functionality 

        // 1. create Chef class ( the Chef has 3 methods that we can use)

        // 2. create Chef Object
        Chef chef = new Chef();
        chef.Makechicken();

        // 3. ItalianChef create an object for ItalianChef
        ItalianChef italianChef = new ItalianChef();
        // makesalad - inherited from Chef
        italianChef.MakeSalad();
        // makepasta - function from IntalitanChef
        italianChef.MakePasta();


        // if I dont want the Italian Chef make bbq ribs for the special dish -- MakeSpacialDish()
        
        // I can override the method
        // then I have to go to Chef class and add virtual in the public void MakeSpacialDish()
        // like this: public virtual void MakeSpacialDish() inisde the Chef class
        // then I can override the method in the ItalianChef class
        // like this: public override void MakeSpacialDish() inside Italian Chef
                // virtual means that it the method can be overriden in any subclass in this case is ItalianChef
                // override means that I am overriding the method in the subclass in this case is ItalianChef
                // then I can call the method in the ItalianChef object
        
        italianChef.MakeSpacialDish();

        
         
        




        Console.ReadLine();


    }
}
