using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0) Console.WriteLine($"the {n} is Negative");
            else if (n > 0) Console.WriteLine($"the {n} is Positive");
            else Console.WriteLine($"the {n} is ZERO");

            if (n % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");


        }
    }
}
