namespace Object_Methods;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the class
        //MyClass obj = new MyClass();
        // Everytime we create objects, the methods get calls 

        // 
        Student student1 = new Student("Jim", "Business", 2.8);
        Student student2 = new Student("Pam","Art", 3.6);

        // call methods
        // cool thing about method is that diferent objects can use 1 method
        // in this case we use method HasHonors for objs student1 and student2  

        System.Console.WriteLine(student1.HasHonors());
        System.Console.WriteLine(student2.HasHonors());
         

        Console.ReadLine();
    }
}
