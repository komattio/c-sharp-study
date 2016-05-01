using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = (int)(Random() >> 58);
            }

            double norm = Norm(array[0], array[1], array[2]);

            WriteArray(array);
            Console.Write("norm = {0}\n", norm);
        }

        static ulong seed = 4275646293455673547UL;
        /// <summary>
        /// 線形合同法による乱数の生成
        /// </summary>
        /// <returns></returns>
        static ulong Random()
        {
            unchecked { seed = seed * 1566083941UL + 1; }
            return seed;
        }

        /// <summary>
        /// 入力した3つのノルムを計算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static double Norm(double x, double y, double z)
        {
            return x * x + y * y + z * z;
        }

        static void WriteArray(int[] array)
        {
            Console.Write("{");
            for(int i=0; i < array.Length-1; ++i)
            {
                Console.Write("{0}, ", array[i]);
            }
            Console.Write(array[array.Length - 1] + "}\n");
        }
    }
}
