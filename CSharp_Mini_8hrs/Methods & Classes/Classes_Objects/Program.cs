namespace Classes_Objects;

class Program
{
    static void Main(string[] args)
    {
        // create a book objects - "the Class Book" tells us what the datetype is. the object is attual instant of the class 
        // book1 is a varibale that store the book objects
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
        





    }
}
