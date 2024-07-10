using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { ID = 101, Name = "ahanaf", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { ID = 102, Name = "mohosen", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { ID = 103, Name = "mugdho", Salary = 7000, Experience = 7 });

        Employee.PromoteEmployee(empList);
        Console.ReadLine();
    }
}

class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList)
    {
        foreach (Employee employee in employeeList)
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " Promoted");
            }
        }
    }
}