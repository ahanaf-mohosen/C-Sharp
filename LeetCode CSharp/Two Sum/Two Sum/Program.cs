using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            //Solution solution = new Solution();
            DictionarySolution solution = new DictionarySolution();
            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine("[" + result[0] + ", " + result[1] + "]");


            Console.ReadLine();
        }
    }
}
