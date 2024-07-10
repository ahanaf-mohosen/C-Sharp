using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello World");
            Console.ReadLine();
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
    
    public delegate void HelloFunctionDelegate(string Message);
}
