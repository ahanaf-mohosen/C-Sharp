using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.printName();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string firstName = "Ahanaf";
        public string lastName = "Mugdho";

        public virtual void printName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " - FullTime Employee");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " - PartTime Employee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void printName()
        {
            Console.WriteLine(firstName + " " + lastName + " - Temporary Employee");
        }
    }
}
