using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class BoundArray
    {
        int[] array;
        int lower;

        public BoundArray(int lower, int upper)
        {
            this.lower = lower;
            array = new int[upper - lower + 1];
        }

        public int this[int i]
        {
            set { this.array[i - lower] = value; }
            get { return this.array[i - lower]; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BoundArray a = new BoundArray(1, 9);

            for (int i = 1; i <= 9; ++i)
            {
                a[i] = i;
            }

            for(int i = 1; i <= 9; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
        }
    }
}
