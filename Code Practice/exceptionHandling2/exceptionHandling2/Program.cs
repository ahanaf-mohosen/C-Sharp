using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader strm = null;
            try
            {
                strm = new StreamReader(@"F:\C# Programing\Code Practice\ExceptionHandling\demo1.txt");
                Console.WriteLine(strm.ReadToEnd());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.GetType().ToString());

            }
            finally
            {
                strm.Close();
                Console.ReadLine();
            }
        }
    }
}
