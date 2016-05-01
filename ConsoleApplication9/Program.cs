using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static double Average(double[] a)
        {
            double y = 0;
            foreach(double x in a)
            {
                y += x;
            }
            return y / a.Length;
        }

        static void Main(string[] args)
        {
            double[] array = new double[81];
            int cnt = 0;
            for(int x = 1; x <= 9; ++x)
            {
                for(int y=1; y <= 9; ++y)
                {
                    int ans = x * y;
                    Console.Write((ans).ToString().PadLeft(3, ' '));
                    array[cnt] = (double)ans;
                    cnt++;
                }
                Console.Write("\n");
            }
            
            Console.WriteLine(Average(array).ToString().PadLeft(3, ' '));
        }
    }
}
