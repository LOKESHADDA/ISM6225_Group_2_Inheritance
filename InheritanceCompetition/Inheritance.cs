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

    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");
   

        }
    }
}
