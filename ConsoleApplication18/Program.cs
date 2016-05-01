using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    /// <summary>
    /// 2次元の点を表す構造体
    /// </summary>
    struct Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }

    /// <summary>
    /// 2次元空間上の三角形を表す構造体
    /// </summary>
    struct Triangle
    {
        public Point a;
        public Point b;
        public Point c;

        /// <summary>
        /// 三角系の面積を求める
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double abx, aby, acx, acy;
            abx = b.x - a.x;
            aby = b.y - a.y;
            acx = c.x - a.x;
            acy = c.y - a.y;
            return 0.5 * Math.Abs(abx * acy - acx * aby);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle t;
            t.a.x = 0;
            t.a.y = 0;
            t.b.x = 3;
            t.b.y = 4;
            t.c.x = 4;
            t.c.y = 3;
            Console.WriteLine("{0}\n", t.GetArea());
        }
    }
}
