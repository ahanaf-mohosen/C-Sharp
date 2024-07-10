using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overrideEqualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.firstName = "Ahanaf";
            e1.lastName = "Mugdho";
            Employee e2 = new Employee();
            e2.firstName = "Ahanaf";
            e2.lastName = "Mugdho";

            Console.WriteLine(e1 == e2);
            Console.WriteLine(e1.Equals(e2));
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Employee))
            {
                return false;
            }
            return this.firstName == ((Employee)obj).firstName &&
                this.lastName == ((Employee)obj).lastName;
        }

        public override int GetHashCode()
        {
            return this.firstName.GetHashCode() ^ this.lastName.GetHashCode();
        }
    }
}
