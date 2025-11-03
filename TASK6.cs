using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK6
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add  2.Subtract  3.Multiply  4.Divide  5.Quit");
                choice = int.Parse(Console.ReadLine());
                if (choice == 5) break;

                Console.Write("Enter two numbers: ");
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Sum = " + (a + b)); break;
                    case 2: Console.WriteLine("Difference = " + (a - b)); break;
                    case 3: Console.WriteLine("Product = " + (a * b)); break;
                    case 4: Console.WriteLine("Quotient = " + (a / b)); break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            } while (true);
        }
    }
}
