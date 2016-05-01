using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            x = GetDouble("input x: ");
            y = GetDouble("input y: ");

            z = x * x + y * y;
            x /= z;
            y /= -z;

            Console.WriteLine("({0}, {1})", x, y);
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
                catch(Exception)
                {
                    Console.WriteLine("error: 正しい値が入力されませんでした.\n入力しなおしてください.");
                    continue;
                }
                break;
            }
            return x;
        }
    }
}
