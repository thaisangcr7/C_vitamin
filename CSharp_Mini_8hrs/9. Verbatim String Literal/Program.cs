namespace _9._Verbatim_String_Literal;

class Program
{
    static void Main(string[] args)
    {
        // backslash character  is also gonna be the escape character  
        // use the first backslash is the reference so they know
        // the second backslash is escape character 
        // \t for tab, \n for new line, \" for speech marks
        // @ calls Verbatim

        // ex: SpeechMark
        string speechMark = " He Said \" somthing\"";
        System.Console.WriteLine(speechMark); // He Said " somthing"

        // Double BackSlash
        string path = "C: \\USer\\CoffeeNCode\\Desktop\\C# Course";
        System.Console.WriteLine(path); // C: \USer\CoffeeNCode\Desktop\C# Course

        // Verbatim
        string path2 = @"C: \\USer\\CoffeeNCode\\Desktop\\C# Course";
        System.Console.WriteLine(path2); // C: \\USer\\CoffeeNCode\\Desktop\\C# Course

        // BackSlash n for new line
        string newlineTest = "C: \\USer\\CoffeeNCode\\Desktop\\C# Course\nNew Line Test";
        System.Console.WriteLine(newlineTest);
        // C: \USer\CoffeeNCode\Desktop\C# Course
        // New Line Test

        // if include the @, we need to add the + 
        string newlineTest2 = @"C: \\USer\\CoffeeNCode\\Desktop\\C# Course" + "\nNew Line Test";
        System.Console.WriteLine(newlineTest2);

        string name  = @"Hello ""Someone""";
        System.Console.WriteLine(name);

        string name1 = " Hello 'Sang' ";
        System.Console.WriteLine(name1);
        

        Console.ReadLine();

    }
}
