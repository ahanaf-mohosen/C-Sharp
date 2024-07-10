using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usefulMethodsOfListCollectionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dictionaryEmployee = new Dictionary<int, Employee>();
            Employee employee1 = new Employee() { Id = 1013, Name = "Rasel", Salary = 20000 };
            Employee employee2 = new Employee() { Id = 1035, Name = "Himu", Salary = 5000 };
            Employee employee3 = new Employee() { Id = 1072, Name = "Mugdho", Salary = 70000 };
            Employee employee4 = new Employee() { Id = 1051, Name = "Sajid", Salary = 10000 };


            List<Employee> listEmployee = new List<Employee>(2);
            listEmployee.Add(employee1);
            listEmployee.Add(employee2);
            listEmployee.Add(employee3);
            listEmployee.Add(employee4);


            Console.WriteLine(listEmployee.TrueForAll(x => x.Salary > 5000));

            Console.ReadLine();
        }
    }



    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
}