using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Inheritance
{
    public class Employee
    {
        public int id;
        public string firstName;
        public string lastName;
        public int email;

        public void printFullName()
        {
            Console.WriteLine($"Full Name = {firstName} {lastName}");
        }
    }
}
