using System;

namespace Interfaces
{
    class Program
    {
        // Interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(new CustomerManager());

            projectManager.Add(new EmployeeManager());

            projectManager.Add(new InternManager());

        }
    }

    interface IPersonManager
    {
        //unimplemented operations
        void Add();
        void Update();

    }

    // inherits - class // implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri Ekleme
            Console.WriteLine("Müşteri Eklendi");        
        }

        public void Update()
        {
            // Müşteri Güncelleme
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            // tajyer Ekleme
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            // Stajyer Güncelleme
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            // Personel Ekleme
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            // Personel Güncelleme
            Console.WriteLine("Personel Güncellendi");
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
