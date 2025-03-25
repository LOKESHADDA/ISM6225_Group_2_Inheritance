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

    public class Staff : Person
{
    public string Position;
    public string Department;

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
