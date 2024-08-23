namespace Classes_Objects;

class Program
{
    static void Main(string[] args)
    {
        // create a book objects - "the Class Book" tells us what the datetype is. the object is attual instant of the class 
        // book1 is a varibale that store the book objects

        /*
        
        // the book1 and book2 are 2 objects = 8 lines of code
        Book book1 = new Book(); 
        book1.title = "Harry Potter"; // book1 here is object that store value 
        book1.author = "J.K. Rowling"; // book1 here is object that store value 
        book1.page = 400; // book1 here is object that store value 

        // Create another object inside the Class Book
        Book book2 = new Book(); 
        book2.title = "Lord of the Rings"; // book1 here is object that store value 
        book2.author = "Tolkien"; // book1 here is object that store value 
        book2.page = 700; // book1 here is object that store value 

        System.Console.WriteLine(book1.title);
        System.Console.ReadLine();
        */

//---------------      // CONSTUCTOR ---------------
        Book book1 = new Book("Harry Potter", "J.K. Rowling", 400);
        Book book2 = new Book("Lord of the Rings","Tolkien",700 );
        Book book3 = new Book();

        System.Console.WriteLine(book2.author);
        System.Console.WriteLine(book1.title);

        Console.ReadLine();







    }
}
