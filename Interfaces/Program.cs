using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
           // manager.Add(new Customer { Id = 1, FirstName = "Tugay", LastName = "Şengül", Address = "İstanbul" }); //aşağıdaki tek satırlık kod bu şekildede yazılabilirdi. ;
           Customer customer = new Customer       
            {                                        
                Id = 1,
                FirstName = "Tugay",
                LastName = "Şengül",
                Address = "İstanbul",

            }; 
            

            Student student = new Student        
           {                                        
               Id = 1,
               FirstName = "Tugay",
               LastName = "Şengül",
               Departmant = "Engineering",

           };
            manager.Add(customer);
            manager.Add(student);

            Console.ReadLine();
        }
    }

    interface IPerson //Soyut
    {
        int Id { get; set; }
        string FirstName { get; }
        string LastName { get; }
    }
    class Customer : IPerson     //somut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
