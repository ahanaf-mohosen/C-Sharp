using System;
using System.Collections.Generic;

namespace delegates2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public delegate bool IsEmployeePromoted(Employee employee);
        public static bool Promoted(Employee emp)
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

        public static void PromoteEmployee(List<Employee> employeeList, IsEmployeePromoted isEmployeePromoted)
        {
            foreach (Employee employee in employeeList)
            {
                if (isEmployeePromoted(employee))
                {
                    Console.WriteLine(employee.Name + " - promoted");
                }
            }
        }
    }
}
