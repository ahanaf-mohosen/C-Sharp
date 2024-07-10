using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_explicitInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.print();
            ((IB)derived).print();
            // or we can write as blow
            IA a = new Derived();
            IB b = new Derived();
            a.print();
            b.print();
            Console.ReadLine();
        }
    }

    interface IA
    {
        void print();
    }
    interface IB
    {
        void print();
    }

    public class Derived : IA, IB
    {
        public void print()
        {
            Console.WriteLine("IA interface method");
        }
        void IB.print()
        {
            Console.WriteLine("IB interface method");
        }
    }
}
