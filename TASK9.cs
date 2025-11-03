using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK9
    {
        static void Change(int a, int[] b)
        {
            a = 10;     
            b[0] = 99;   
        }
        public static void Main(string[] args)
        {
            int num = 5;
            int[] nums = { 1, 2, 3 };

            Change(num, nums);
            Console.WriteLine("num = " + num);
            Console.WriteLine("nums[0] = " + nums[0]);
        }
    }
}
