using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                { 
                    FirstName="Tugay"
                }, 
                new Student
                {
                    FirstName="Sen"
                }, 
                new Person
                {
                    FirstName="Taner"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

  
    class Student : Person //Bir nesneyi birkez inheritance alabiliriz ama birden fazla implementasyon yapabiliriz.
    {                      //Önce inheritance sonra kaçtane varsa interface yazılabilir.
        public string Department { get; set; }
    }
}
