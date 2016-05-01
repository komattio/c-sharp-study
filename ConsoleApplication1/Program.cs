using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("実部を入力してください:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("虚数を入力してください:");
            double y = double.Parse(Console.ReadLine());

            double norm = x * x + y * y;

            Console.Write("{0} + i({1}) の逆数は {2} + i{3} \n", x, y,
                x / norm, -y / norm);
        }
    }
}
