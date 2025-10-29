using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK1
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18) Console.WriteLine($"The age {age} is Minor ");
            if (age >=18 ) Console.WriteLine($"The age {age} is Adult ");
            if (age > 60) Console.WriteLine($"The age {age} is Senor ");
        }
    }
}
