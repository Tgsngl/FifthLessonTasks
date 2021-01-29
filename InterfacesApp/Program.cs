using System;

namespace InterfacesApp
{
    class Program
    {
        //İnterface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customManager = new CustomManager();
          
            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new InternManager());
            

            Console.ReadLine();
        }
        
    }

   interface IPersonManager
    {
        //unimplemented Operation
        void Add();
        void Update();
    }

    //Inheritance
    class CustomManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
       
    }
}
