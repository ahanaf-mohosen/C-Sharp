using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ParentClass
    {
        public ParentClass() 
        {
            Console.WriteLine("ParentClass Constructor called");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
