using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            for (int i = 0; i < 100; i++)
            {
                count *= 5;
                Console.WriteLine($"The value of count is { count }");
            }

            Console.ReadLine();
        }
    }
}
