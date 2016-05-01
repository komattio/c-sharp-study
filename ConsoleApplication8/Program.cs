using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("1つ目の整数を入力してください: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("2つ目の整数を入力してください: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("{0}と{1}の最大公約数は", a, b);

            // ユークリッド互除法を使ってaとbの最大公約数を求める
            while(b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }

            Console.WriteLine("{0}", a);
        }
    }
}
