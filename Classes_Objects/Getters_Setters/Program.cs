namespace Getters_Setters;

class Program
{
    static void Main(string[] args)

    {
        // Getters_Setters are different types of methods that sure the classes are secure 
        Movie avengers = new Movie("The Avengers", "Joss Whedon", "R");
        Movie Shrek = new Movie("Shrek", "Adam", "PG");

        // valid rating we can have for rating is below
        // G, PG, PG-13, R, NR
        
        //Console.WriteLine(avengers.rating) // this will give the error since rating is private inside the Movie class
        Console.WriteLine(avengers.Rating);
        Console.ReadLine();
         
    }
}
