using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Employee> dictionaryEmployee = new Dictionary<int,Employee>();
            Employee employee1 = new Employee() { Id = 1013, Name = "Rasel", Salary = 2000.50f };
            Employee employee2 = new Employee() { Id = 1035, Name = "Himu", Salary = 5000 };
            Employee employee3 = new Employee() { Id = 1072, Name = "Mugdho", Salary = 70000 };

            dictionaryEmployee.Add(employee1.Id, employee1);
            dictionaryEmployee.Add(employee2.Id, employee2);
            dictionaryEmployee.Add(employee3.Id, employee3);

            Employee cust = dictionaryEmployee[1072];


            foreach(KeyValuePair<int,Employee> kvp in dictionaryEmployee)
            { 
                int employeeKey = kvp.Key;
                Employee employeeValue = kvp.Value;
                Console.WriteLine("[Key = {0}]", employeeKey);
                Console.WriteLine(employeeValue.Name);
                Console.WriteLine(employeeValue.Salary);
                
            }
            Console.ReadLine();

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary {  get; set; }
    }
}
