using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK4
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number 1 to 7: ");
             int day =int.Parse(Console.ReadLine());

            switch(day)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default:Console.WriteLine("Invalid"); break;





            }


        }
    }
}
