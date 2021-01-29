using System;

namespace InterFacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }
    interface IWorker
    {
        
        void Work();
    }

    //SOLID, Interface Segragation
    interface IEat
    {
        void Eat();
    }

    interface ISalary    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manage ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manage got salary");
        }

        public void Work()
        {
            Console.WriteLine("Manage worked");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker ate");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker got salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker worked");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot worked");
        }
    }
}
