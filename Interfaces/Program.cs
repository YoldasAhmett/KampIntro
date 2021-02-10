using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(employeeManager);
            projectManager.Delete(customerManager);
            projectManager.Delete(new InternManager());
        }

        interface IPersonManager
        {
            void Add();
            void Delete();
        }

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Customer eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("Customer silindi");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Employee eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("Employee silindi");
            }

        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajyer eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("Stajyer silindi");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }

            public void Delete(IPersonManager personManager)
            {
                personManager.Delete();
            }
        }

    }
}
