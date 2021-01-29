using System;

namespace FifthLessonTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Tugay"; //= kullandığımız zaman Customer klasındaki FirstName in get(Al) kısmı çalışır.
            customer.LastName = "Şengül";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Tugay",
                LastName = "Şengül"
            };
            Console.WriteLine(customer2.FirstName); //Customer sayfasında yaptığım Mr. kodlamalarından sonra burada FisrtName in başına Mr. koydu.

            Console.ReadLine();
        }
    }

   
   
}
