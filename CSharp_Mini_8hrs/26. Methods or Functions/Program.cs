namespace _26._Methods_or_Functions;

// Go to Methods & Classes Folder for more details

class Program
{
    // Methods or Functions 
        // Dry - Dont repeat yourself
        // Methods or Functions are blocks of code that can be called multiple times from different parts of the
        // program. They can take arguments and return values.
    // we can create functions in side of the class
    // new Function
    static void welcomeMessage()
    {
        System.Console.WriteLine("Sang is going to be Developer");
    }
    
    public class Test
    {
        public void something()
        {
            System.Console.WriteLine("Hello");
            
        }
    }
    
    static void Main(string[] args)
    {
        System.Console.WriteLine("Sang is going to be Developer");
        welcomeMessage();
        Test test = new Test(); // we have to create an object because we did not use the static. 
        test.something();

    }

    // 
    
}
