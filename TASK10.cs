using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK10
    {
        public static void Main(string[] args)
        {
            int? x = null;
            Console.WriteLine(x ?? 100);s

            dynamic y = 5;
            Console.WriteLine("y = " + y);
            y = "Now I'm a string";
            Console.WriteLine("y = " + y);
        }
    }
}
