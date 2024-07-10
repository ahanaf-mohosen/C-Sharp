using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.constructor___distructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.printFullName();
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public string firstName;
        public string lastName;

        public Customer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Customer() : this("No First Name Provided", "or No Last Name Provided")
        {
           
        }
        public void printFullName()
        {
            Console.WriteLine($"Full Name = {firstName} {lastName}");
        }
        ~Customer()
        {
            //clean up code
        }
    }
}
