using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("input b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("整数: {0} / {1} = {2} ... {3}\n", a, b, a / b, a % b);
            Console.Write("実数: {0} / {1} = {2}\n", a, b, a / (double)b);
        }
    }
}
