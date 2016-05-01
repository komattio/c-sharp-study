using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM = 5;
            int[] array = new int[NUM];

            for (int i = 0; i < NUM; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int sq_sum = 0;

            for(int i=0; i<NUM; ++i)
            {
                int n = array[i];
                sum += n;
                sq_sum += n * n;
            }

            double mean = sum / (double)NUM;
            double var = sq_sum / (double)NUM - mean * mean;

            Console.WriteLine("平均: {0}\n分散: {1}\n", mean, var);

            // 円周率
            Console.WriteLine("円周率: {0}\n", Math.PI);
        }
    }
}
