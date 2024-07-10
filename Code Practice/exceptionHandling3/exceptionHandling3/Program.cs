using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("First Number = ");
                    int fn = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Second Number = ");
                    int sn = Convert.ToInt32(Console.ReadLine());

                    int result = fn / sn;
                    Console.WriteLine("Result = {0}", result);
                }
                catch (Exception ex)
                {
                    string filePath = @"F:\C# Programing\Code Practice\exceptionHandling3\log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Current Exception = " + ex.GetType().Name);
                Console.WriteLine("Inner Exception = " + ex.InnerException.GetType().Name);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
