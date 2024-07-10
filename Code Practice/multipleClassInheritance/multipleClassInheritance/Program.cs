using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleClassInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.APrint();
            ab.BPrint();
            Console.ReadLine();
        }
    }

    public interface IA
    {
        void APrint();
    }
    public class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("A");
        }
    }
    public interface IB 
    {
        void BPrint();
    }
    public class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("B");
        }
    }
    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void APrint()
        {
            a.APrint();
        }
        public void BPrint()
        {
            b.BPrint();
        }
    }
}
