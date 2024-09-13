namespace _41._Structures;

class Program
{
    // struct is helpful to store different type of data
    struct Person // structure Person
        {
            private string passWTest; // make it private inside the struct person
            public string name; // make it public field so I can use it 
            public int age;
            public int birthMonth;

            public int number;

            // Constructor for the struct
            // This code defines a struct called Person with four public fields: 
            // name, age, birthMonth, and number. It also has a private field passWTest. 
            //The constructor initializes the public fields with the provided parameters.
            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name; // this will refer to varible under truct person
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        }
    static void Main(string[] args)
        {
        // string name = "abe"
        // int age = 12;
        // int birthMonth = 10;
        
        // Person person;

        // person.name = "Sang";
        // person.age = 19;
        // person.birthMonth = 4;
        // //person.passWTest = "sT" // this does not work because passWTest is not accessible

        // System.Console.WriteLine($"{person.age}, {person.birthMonth}, {person.name}");


        Person person = ReturnPerson();
        System.Console.WriteLine($"{person.age}, {person.birthMonth}, {person.name}, {person.number}"); 
        
        Console.ReadLine();

        }
    // static string ReturnPerson(out int age)
    // {
    //     System.Console.WriteLine("Enter your name: ");
    //     string name = System.Console.ReadLine();
    // }


    static Person ReturnPerson()
    {
        System.Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        System.Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Your Birthmonth: ");
        int birthMonth = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter Your Number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Person person;
        // person.name = name;
        // person.age = age;
        // person.birthMonth = birthMonth;
        // person.number = number;

        // return person;

        return new Person(name, age, birthMonth, number);
        
    }


}
