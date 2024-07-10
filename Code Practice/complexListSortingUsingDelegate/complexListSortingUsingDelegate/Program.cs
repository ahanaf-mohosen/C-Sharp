using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexListSortingUsingDelegate
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


            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(employee1);
            listEmployee.Add(employee2);
            listEmployee.Add(employee3);
            listEmployee.Add(employee4);

            //Comparison<Employee> comparisonEmployee = new Comparison<Employee>(CompareEmployee); //Apporach-1
            //listEmployee.Sort(comparisonEmployee); //Apporach-1


            //listEmployee.Sort(delegate (Employee e1, Employee e2) //Apporach-2
            //{
            //    return (e1.Id.CompareTo(e2.Id));
            //});

            listEmployee.Sort((e1, e2) => e1.Id.CompareTo(e2.Id)); //Apporach-3

            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine(employee.Id);
            }


            Console.ReadLine();
        }
        //private static int CompareEmployee(Employee x, Employee y) //Apporach-1
        //{
        //    return x.Id.CompareTo(y.Id);
        //}
    }



    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
}