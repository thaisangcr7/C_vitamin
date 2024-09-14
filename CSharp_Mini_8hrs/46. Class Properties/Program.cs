using System.Reflection.Metadata.Ecma335;

namespace _46._Class_Properties;

class Program
{

    class Person
    {
            private string name;
            private int age;

        // turn the 2 fields below into properties using get and set
            // public string Name
            // {
            //     get
            //         {
            //             return name;
            //         }
            //     set
            //         {
            //             name = value; // using value as default
            //         }
            // }
            // public int Age
            // {
            //     get
            //         {
            //             return age;
            //         }
            //     set
            //         {
            //             age = value; // using value as default
            //         }
            // }

        // make it look nicer
            public string Name 
            {
                get => name; 
                set => name = value;
            }
            public int Age 
            {
                get => age; 
                set => age = value;
            }
       
        // name1 and age1 are Auto-Implemented properties that act the same with our 2 example get and set above
            public string name1 {get; set;}
            public int age1 {get; set;}

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

            Name = name;
            Age = age;
        }

        // public void SetName(string name)
        // {
        //     this.name = !string.IsNullOrEmpty(name) ? name : "InvalidName!";
        // }

        // public string GetName()
        // {
        //     return name;
        // }

        // public void SetAge(int age)
        // {
        //     this.age = age >= 0 && age <= 150 ? age : -1;
        // }

        // public int GetAge()
        // {
        //     return age;
        // }

        public string ReturnDetails()
        {
            return $"Name: {name}, Age: {age}";
        }

    }



    static void Main(string[] args)
    {
        Person person = new Person("Sang", 23);
        System.Console.WriteLine(person.ReturnDetails());

        person.Name = "Harry";
        System.Console.WriteLine(person.ReturnDetails());

        person.Age = 30;
        System.Console.WriteLine(person.ReturnDetails());

        System.Console.WriteLine($"your name is {person.Name} and your age is {person.Age}");
        Console.ReadLine();
    }
}
