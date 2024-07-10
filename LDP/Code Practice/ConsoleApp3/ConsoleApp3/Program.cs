using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3
{
    class Delegate
    {
        public static void Main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { ID = 101, Name = "Mohan", Salary = 5000, Experience = 5 });
            emplist.Add(new Employee() { ID = 102, Name = "Alan", Salary = 6000, Experience = 6 });
            emplist.Add(new Employee() { ID = 103, Name = "Suresh", Salary = 7000, Experience = 3 });
            emplist.Add(new Employee() { ID = 104, Name = "Jay", Salary = 4000, Experience = 3 });
            emplist.Add(new Employee() { ID = 105, Name = "Sachin", Salary = 4500, Experience = 3 });
            IsPromotable del = new IsPromotable(Promote);
            Employee.PromoteEmployee(emplist, del);
            Console.ReadLine();
        }
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeelist, IsPromotable isEligibleToPromote)
        {
            foreach (Employee employee in employeelist)
            {
                if (isEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " is promoted");
                }
            }
        }
    }
}