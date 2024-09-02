namespace Arrays_Lists_Indexing_ForEach;

class Program
{
    static void Main(string[] args)
    {
    // /*
        // 1. List =============================================
        // Create a new list of strings called "names" and initialize it with three elements
        var names = new List<string> { "Scott", "Ana", "Felipe"};
        
        // Add three more elements to the list
        names.Add("David");
        names.Add("Damian");
        names.Add("Maria");

        // Print the entire list
        // foreach (var name in names)
        // {
        //     Console.WriteLine($"Hello {name.ToUpper()}");
        // }

    //Print the subset from the list from the 2nd to 4th =============================================
    // range  =============================================
        foreach (var name in names[2..4])
        {
            Console.WriteLine($"Hello {name.ToUpper()}");
        }

        // Print specific elements of the list using indexing
        Console.WriteLine("\nAccessing elements using indexing:");
        System.Console.WriteLine(names[0]);
        System.Console.WriteLine(names[^2]); // -- second from the end - Element at index -2 (from the end) 
    //*/

// ==========================================================================================
        /*
        // 2. Array =============================================
        // Arrays is a uinversal to store a list of things 
        // make a string array

        // make a string array for names 
        // arrays are fixed in length which means I cannt add new name, 
        //or fix the names inside the arrays
        // I can only make another new array

        var names2 = new string[] { "Scott", "Ana", "Felipe"};

        // Make "new array" with Damian and all names from names2
        names2 = [..names2, "Damian"]; // This means that create a new array that copy everything from old array,
        // then add Damian to the new Array

        // names2.Add("David"); // array does not allow Add
        foreach (var name2 in names2)
        {
            Console.WriteLine(name2);
        }

        */



        // Another way to make an array
        /*
        string[] colors = { "Red", "Green", "Blue", "purple", "yellow"};
        // Print the entire array
        Console.WriteLine("\nPrinting the entire array:");
        Console.WriteLine(colors[0]);

        // print array
        foreach (var color in colors[2..4])
        {
            Console.WriteLine(color);
        }
        */
        
        



    }
}
