using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Employee
    {
        public void printName()
        {
            Console.WriteLine("Parent Class");
        }
    }

    public class FullTimeClass : Employee 
    {
        public new void printName()
        {
            base.printName();
        }

        public void name()
        {
            base.printName();
        }
    }
}
