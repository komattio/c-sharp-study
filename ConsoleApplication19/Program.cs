using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Complex
    {
        public double re; // 実部
        public double im; // 虚部

        /// <summary>
        /// 絶対値を返す
        /// </summary>
        /// <returns></returns>
        public double Abs()
        {
            return Math.Sqrt(re * re + im * im);
        }

        /// <summary>
        /// 文字列化する
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (im > 0)
                return re.ToString() + "+i" + im.ToString();
            if (im < 0)
                return re.ToString() + "-i" + (-im).ToString();
            return re.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex();
            z.re = GetDouble("実部を入力してください: ");
            z.im = GetDouble("虚部を入力してください: ");

            Console.WriteLine("|{0}| = {1}", z, z.Abs());
        }

        static double GetDouble(string message)
        {
            double x;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    x = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("error: 正しい値が入力されませんでした。\n入力しなおしてください");
                    continue;
                }
                break;
            }
            return x;
        }
    }
}
