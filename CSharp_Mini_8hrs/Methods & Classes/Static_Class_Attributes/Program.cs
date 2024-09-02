namespace Static_Class_Attributes;

class Program
{
    static void Main(string[] args)   // static is also an attributes of the class
    {

        // note: everytimes I put in = new Song(),  => I am calling a Constructor
        Song holiday = new Song("Holiday", "Green day", 200);
        System.Console.WriteLine($"static: {Song.Songcount}"); // result: 1 - this is the attributes about the class 
        Song kashmir = new Song("kashmir", "Led day", 150);
        System.Console.WriteLine($"static: {Song.Songcount}"); // result: 2 - this is the attributes about the class 

        // now I can count the song for each of the object using getsongcount method that allow object to access
        // note: Songcount is the attribute of the class not for the method. 
        System.Console.WriteLine($"Holiday song count: {holiday.Getsongcount()}");

        // a normal attribute for each object -- example below:
        System.Console.WriteLine(holiday.artist);
        System.Console.WriteLine(kashmir.artist );

        // stattic arrtirubute is a unique attribute about the atuall class 
        // a stratic arrtribite is gonna be the same attribute for all the object inside the class 
        // using this static I can count how many object has been created inside the class
        System.Console.WriteLine($"static: {Song.Songcount}") ;


        Console.ReadLine();
    }
}
