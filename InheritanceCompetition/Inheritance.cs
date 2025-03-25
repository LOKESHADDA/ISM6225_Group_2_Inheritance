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
}


    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");
   

        }
    }
}
