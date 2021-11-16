using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, x, y = 0;
            Console.Write("Введите n");
            n = Convert.ToDouble(Console.ReadLine());
            for (x=1; x<=n; x++)
            {
                Console.WriteLine($"{y}+{x}=" + (y + x));
                y = y + x;
            }
            Console.ReadKey();

        }
    }
}
