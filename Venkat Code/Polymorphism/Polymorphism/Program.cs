using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName+" "+LastName);
    }
}

public class FullTimeEmployee:Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName+" -FullTime");
    }
}

public class PartTimeEmployee:Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " -PartTime");
    }
}

public class TemporaryEmployee:Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " -Temporary");
    }
}
namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new TemporaryEmployee();
            employees[3] = new PartTimeEmployee();

            foreach(Employee e in employees)
            {
                e.PrintFullName();
            }

            Console.ReadLine();
        }
    }
}
