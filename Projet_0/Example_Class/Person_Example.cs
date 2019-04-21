using System;

namespace Projet_0
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company)
            : base(firstName, lastName)
        {
            Company = company;
        }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
        }
    }
}