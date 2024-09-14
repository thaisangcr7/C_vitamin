using System.Reflection.Metadata.Ecma335;

namespace _43._Class_Function;

class Program
{

    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;

        }

        // function inside the class
        public string ReturnDetails()
        {
            return $"Name: {name}\nAge: {age}";
        }
    }
    static void Main(string[] args)
    {
        Person person = new Person("sang", 19);
            //System.Console.WriteLine($"Name: {person.name}\nAge: {person.age}");
            // using function - just for reference because it is not scable
                //System.Console.WriteLine(ReturnDetails(person.name, person.age));
                //System.Console.WriteLine(ReturnDetails(person));

        // call function that was wrapped inside the class
        System.Console.WriteLine(person.ReturnDetails());
    }

    // function
    // static string ReturnDetails(string name, int age)
    // {
    //     return $"Name: {name}\nAge: {age}";
    // }

    // function is to pass the class in
        // static string ReturnDetails(Person person)
        // {
        //     return $"Name: {person.name}\nAge: {person.age}";

        // }
}
