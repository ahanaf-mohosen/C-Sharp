using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using ProjectA_TeamA;
using ProjectA_TeamB;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            TeamA.print();
            TeamB.print();
            Console.ReadLine();
        }
    }
}
