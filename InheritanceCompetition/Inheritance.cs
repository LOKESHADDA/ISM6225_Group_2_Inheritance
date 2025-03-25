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

            // Create books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            // Create patrons
            Person student1 = new Person("Akhil", "akhil@usf.edu", "S001");
            Person student2 = new Person("Sandeep", "sandeep@usf.edu", "S002");

            Staff staff1= new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            // Create library and add books and patrons
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddPatron(student1);
            library.AddPatron(student2);
            library.AddPatron(staff1);

            // Display books and patrons
            library.DisplayBooks();
            library.DisplayPatrons();

            // Borrow books
            Console.WriteLine("\nBorrowing Books...");
            library.BorrowBook(student2, book2);  // Sandeep borrows "Business Insights with AI"
            library.BorrowBook(student1, book3);  // Akhil borrows "Analytics in Action"

            // Display updated library information after borrowing
            library.DisplayBooksAfterBorrowing();
        }
    }
}
