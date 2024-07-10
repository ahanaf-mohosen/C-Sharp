using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee employee = new FullTimeEmployee();
            employee.firstName = "Ahanaf";
            employee.lastName = "Mugdho";
            employee.yearlySalary = 100000;
            employee.printFullName();
            Console.ReadLine();
        }
    }
}
