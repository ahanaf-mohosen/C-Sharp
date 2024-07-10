using System;
using System.Collections.Generic;
using static delegates2.Employee;

namespace delegates2
{
    public class Program
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Id = 1013, Name = "Rasel", Salary = 50000, Experience = 4});
            empList.Add(new Employee() { Id = 1072, Name = "Mugdho", Salary = 55555, Experience = 5 });

            //Employee.IsEmployeePromoted employeePromoted = new Employee.IsEmployeePromoted(Employee.Promoted);
            //Employee.PromoteEmployee(empList, employeePromoted);
            Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
            Console.ReadLine();
        }
    }
}
