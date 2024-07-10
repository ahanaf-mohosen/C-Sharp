using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int k in arr)
            {
                int j = 0;
                Console.Write($"arr[{j}] = ");
                Console.WriteLine(k);
                j++;
            }
            Console.ReadLine();
        }
    }
}
