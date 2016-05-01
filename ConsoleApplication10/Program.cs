using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // Excercise 1
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (i = 1; i <= n; ++i)
            {
                sum += i;
            }

            Console.WriteLine("loop {0}, formula {1}", sum, n * (n + 1) / 2);

            // Excercise 2
            Console.Write("整数を入力してください: ");
            n = int.Parse(Console.ReadLine());

            for (i =0; i <= n; ++i)
            {
                if (n == i * i) break;
            }

            if (i <= n) Console.Write("{0} = {1} * {1} は平方根です\n", n, i);
            else Console.Write("{0}は平方根ではありません\n", n);

            // Excercise 3
            for(i = 1; i <= 9; ++i)
            {
                for(int j = 1; j <= 9; ++j)
                {
                    Console.Write("{0,3}", i * j);
                }
                Console.Write("\n");
            }
        }
    }
}
