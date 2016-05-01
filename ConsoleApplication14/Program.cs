using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 314, b = 159, c = 265, d = 358, e = 979;

            int max = Max(a, b, c, d, e);

            Console.Write("{0}\n", max);
        }

        static int Max(params int[] a)
        {
            int max = a[0];
            for(int i=1; i<a.Length; ++i)
            {
                if(max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}
