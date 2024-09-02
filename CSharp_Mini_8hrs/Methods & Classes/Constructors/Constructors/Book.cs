using System;

namespace Classes_Objects;

public class Book // 1. define a book here wuth class book
   
    { // 2. Atrribute - define the book data type that will be use for Book
    public string? title;
    public string? author;
    public int page;

    // Create a Constructor - 
    // Constructor is a special method inside of our class, that gonna get call when we create an object of this class
    // everytime we use public + class name(), we are creating a constructor
    // in this class we create a Book constructor
    // public Book(string name) 
    // {
    //     System.Console.WriteLine(name); 

    // }

    // Create a robust books with Constructor! 
    public Book(string aTitle, string aAuthor, int aPage)
    {
        title = aTitle; // book1.title = "ssss" 
        author = aAuthor;
        page = aPage;
    }

    // book3 with no argument in it
    public Book()
    {

    }


    }
