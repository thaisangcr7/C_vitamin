using System.Security.Authentication.ExtendedProtection;

namespace _42._Classes;

class Program
{
    // Struct 
    // struct is very similat to class, but it has to have the parameters
        // struct Person
        // {
        //     public string name;
        //     public int age;
        //     public Person(string name, int age)
        //     {
        //         this.name = name;
        //         this.age = age;
        //     }
        // }
    
    // class
    // class does not need parameters
    // I can add classes inside my class and can overide it
        class Person
        {
            // create fields for name and age
            public string name;
            public int age;

                public Person()
                {

                }

                public Person(string name)
                {
                    this.name = name;
                    this.age = -1;
                }
                public Person(int age)
                {
                    this.age = age;
                    this.name = "";
                }
                public Person(string name, int age)
                {
                    this.name = name;
                    this.age = age;
                }
        }
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Person person = new Person(name, age);

        if (!string.IsNullOrEmpty(person.name))
        {
        Console.WriteLine(person.name);
        }
        if (person.age > -1)
        {
        Console.WriteLine(person.age);
        }

        Console.ReadLine();
    }
}
