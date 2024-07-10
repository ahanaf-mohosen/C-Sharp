using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> dictionaryEmployee = new Dictionary<int, Employee>();
            Employee employee1 = new Employee() { Id = 1013, Name = "Rasel", Salary = 2000.50f };
            Employee employee2 = new Employee() { Id = 1035, Name = "Himu", Salary = 5000 };
            Employee employee3 = new Employee() { Id = 1072, Name = "Mugdho", Salary = 70000 };


            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(employee1);
            listEmployee.Add(employee2);
            listEmployee.Add(employee3);

            Dictionary<int,Employee> employee = listEmployee.ToDictionary(emp => emp.Id, emp => emp);

            foreach(KeyValuePair<int, Employee> kvp in employee)
            {
                int empKey = kvp.Key;
                Employee empValue = kvp.Value;
                Console.WriteLine(empKey);
                Console.WriteLine(empValue.Name);
                Console.WriteLine(empValue.Salary);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set;}
    }
}
