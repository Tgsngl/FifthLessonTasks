using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new BaseCustomerManager();
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1993,8,7), FirstName="Tugay", LastName="Şengül", NationalityId="456767"});
            Console.ReadLine();
        }
    }
}
