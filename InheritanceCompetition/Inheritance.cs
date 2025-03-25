using System;

namespace Inheritance
{
    public class Person
    {
        public string Name;
        public string Email;
        public string ID;

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
        
    }
    public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title, string author, string isbn, int availableCopies)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        AvailableCopies = availableCopies;
    }

    public bool BorrowBook()
    {
        if (AvailableCopies > 0)
        {
            AvailableCopies--;
            return true;
        }
        return false;
    }

    public void ReturnBook()
    {
        AvailableCopies++;
    }
}

public class Library
{
    public List<Book> Books { get; set; } = new List<Book>();
    public List<Person> Patrons { get; set; } = new List<Person>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddPatron(Person person)
    {
        Patrons.Add(person);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books in Library:");
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
        }
    }

    public void DisplayPatrons()
    {
        Console.WriteLine("\nPatrons in Library:");
        foreach (var patron in Patrons)
        {
            Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
        }
    }
     public void BorrowBook(Person patron, Book book)
        {
            if (book.BorrowBook())
            {
                Console.WriteLine($"{patron.Name} borrowed '{book.Title}'");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is not available.");
            }
        }

        // New method to display books after borrowing
        public void DisplayBooksAfterBorrowing()
        {
            Console.WriteLine("\nBooks after borrowing:");
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
        }
}


    public class Student : Person
{
   public string Major; 
   public int GraduationYear;
   public Student(string name, string email, string id, string major, int graduationYear)
       : base(name, email, id)
   {
       Major = major;
       GraduationYear = graduationYear;
   }
}
public class Staff : Person
{
    public string Position { get; set; }
    public string Department { get; set; }

    public Staff(string name, string email, string id, string position, string department)
        : base(name, email, id)
    {
        Position = position;
        Department = department;
    }
}

    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");
   

        }
    }
}
