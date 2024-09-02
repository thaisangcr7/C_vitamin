namespace Static_Methods_Classes;

class Program
{
    static void Main(string[] args)
    {
        // in this example: I dont have create to create an instance for the math class
        // normal: Math Mymath = new Math();
        // and because Math is a static of the class we cannt create an instance ---Math Mymath = new Math();--- with obj like Mymath 
        
        // this example: the Math the method belong to the class, so we donot have to create the instance for method
        System.Console.WriteLine(Math.Sqrt(144));

        // over here in - we can access that method without create an instant 
        UsefulTools.SayHi("Sang");

        // public class UsefulTools
        // we create an instance for UsefulTools different objects -- in this case obj is newtools
        // ex: UsefulTools newtools = new UsefulTools();

        // but if we add static to public class UsefulTools
        // public static class UsefulTools
        // now we cannot create an instance with UsefulTools class because it is static that can only access by UsefulTools class. 



        Console.ReadLine();
    }
}
