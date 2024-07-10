using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent class")
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }
}
