using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; ++i)
            {
                double x = 0.01 * i;
                double y = Sin(x);
                Console.WriteLine("sin({0:f2}) = {1:f6}\n", x, y);
            }
        }

        static double Sin(double x)
        {
            double xx = -x * x;
            double fact = 1;
            double sin = x;

            for(int i=1; i < 100;)
            {
                fact *= i; ++i; fact *= i; ++i;
                x *= xx;
                sin += x / fact;
            }
            return sin;
        }
    }
}
