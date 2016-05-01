using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Point
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1.x = 100;
            p1.y = 0;

            p2.x = 400;
            p2.y = 400;

            Console.WriteLine("{0} と {1} の間の距離は{2}", p1, p2, Distance(p1, p2));
        }

        private static object Distance(Point p1, Point p2)
        {
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
