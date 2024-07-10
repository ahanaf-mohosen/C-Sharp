using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string userString = "C#";
            //userString += " Video";
            //userString += " Tutorial";
            //userString += " For";
            //userString += " Begineers";
            //Console.WriteLine(userString);

            StringBuilder str = new StringBuilder("C#");
            str.Append(" videos");
            str.Append(" tutorial");
            str.Append(" for begineers");
            Console.WriteLine(Convert.ToString(str));

            Console.ReadLine();
        }
    }
}
