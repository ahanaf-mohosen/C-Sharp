using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._1.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            childClass c1 = new childClass();
            Console.ReadLine();
        }
        
        public class parentClass
        {
            public parentClass()
            {
                Console.WriteLine("Parent class called.");
            }
            public parentClass(string Message)
            {
                Console.WriteLine($"{Message}");
            }
        }

        public class childClass : parentClass 
        {
            public childClass() : base("Parameter Constructor call.") 
            {
                Console.WriteLine("Child class called.");
            }
        }
    }
}
