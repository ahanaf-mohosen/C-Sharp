using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Ahanaf",
                Salary = 50000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Mohosen",
                Salary = 70000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Mugdho",
                Salary = 80000
            };

            Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
            {
                customerDictionary.Add(customer1.ID, customer1);
                customerDictionary.Add(customer2.ID, customer2);
                customerDictionary.Add(customer3.ID, customer3);

                Customer customer101 = customerDictionary[101];
                //Console.WriteLine("ID = {0} \nName = {1} \nSalary = {2}", customer101.ID, customer101.Name, customer101.Salary);
                
                foreach(KeyValuePair<int, Customer> kvp in customerDictionary)
                {
                    Console.WriteLine(kvp.Key);
                }

                Console.ReadLine();
            }
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }
    }
}
