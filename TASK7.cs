using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_PracticeCode.LAB_29_10_2025
{
    internal class TASK7
    {
        public static void Main(string[] args)
        {
            string word;
            int count = 0;

            while (true)
            {
                Console.Write("Enter a word  exit to stop): ");
                word = Console.ReadLine();
                if (word == "exit") break;
                count++;
            }
            Console.WriteLine("Total words entered: " + count);
        }
    }
}
