using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    /// <summary>
    /// 2次元の点を表す構造体
    /// </summary>
    struct Point
    {
        public double x;
        public double y;

        /// <summary>
        /// 座標値(x, y)を与えて初期化
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }
    
    /// <summary>
    /// 2次元空間上の三角形を表すクラス
    /// </summary>
    class Triangle
    {
        public Point a;
        public Point b;
        public Point c;
        
        /// <summary>
        /// 3つの頂点の座標を与えて初期化
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// 三角形の面積を求める
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
            Triangle t = new Triangle(
                new Point(0, 0),
                new Point(3, 4),
                new Point(4, 3));

            Console.WriteLine("{0}", t.GetArea());
        }
    }
}
