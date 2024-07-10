using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyTwo;
using AssemblyOne;

namespace accessReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AssemblyClassTwo x = new AssemblyClassTwo();
            int y = x.sum;
            AssemblyClassOne z = new AssemblyClassOne();
            int p = z.product;
        }
    }
}
