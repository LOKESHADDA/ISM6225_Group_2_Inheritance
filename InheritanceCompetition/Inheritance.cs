using System;

namespace Inheritance
{
    public class Person
    {
        protected string Name;
        protected string Email;
        protected string ID;

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
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

    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");
   

        }
    }
}
