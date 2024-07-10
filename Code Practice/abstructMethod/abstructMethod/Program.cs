using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abstructMethod
{
    internal class Program : BaseClass
    {
        public override void print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.print();
            Console.ReadLine();
        }
    }

    public abstract class BaseClass
    {
        public abstract void print();
    }
}
