using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace enumProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Name = "Ahanaf";
            //employee.Id = 1072;
            //employee.Gender = (Gender)1;
            //Console.WriteLine(employee.Gender);

            /// Reflection ///
            ///            ///
            //Type T = Type.GetType("enumProblem.Employee");
            //PropertyInfo[] properties = T.GetProperties();
            //foreach (PropertyInfo property in properties)
            //{
            //    Console.WriteLine(property.Name);
            //}

            //Employee employee = new Employee();
            //Type t = employee.GetType();
            //Console.WriteLine(t.GetProperties());

            //PropertyInfo[] info = t.GetProperties();
            //foreach (PropertyInfo pi in info)
            //{
            //    Console.WriteLine(pi.Name);
            //}

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type employeeType = executingAssembly.GetType("enumProblem.Employee");
            object customerInstance = Activator.CreateInstance(employeeType);
            MethodInfo getFullNameMethod = employeeType.GetMethod("getFullName");

            string[] parameters = new string[2];
            parameters[0] = "Ahanaf";
            parameters[1] = "Mugdho";

            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine(fullName);

            Console.ReadLine();
        }
    }

    public class a
    {
        public void print()
        {
            Console.WriteLine("Hello");
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public string getFullName(string firstName,string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
