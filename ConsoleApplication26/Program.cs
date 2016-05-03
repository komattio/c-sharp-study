using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class StaticDemo
    {
        public static int Val = 100;
        public static int ValDiv2()
        {
            return Val / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial value of StaticDemo.val is " + StaticDemo.Val);

            StaticDemo.Val = 8;
            Console.WriteLine("StaticDemo.val is " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());

            sub();

            Console.WriteLine("StaticDemo.val is " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDiv2(): " + StaticDemo.ValDiv2());
        }

        private static void sub()
        {
            Console.WriteLine("\n------ start sub functuion ------");
            StaticDemo.Val = 2;
            Console.WriteLine("StaticDemo.Valに2を代入しました.");
            Console.WriteLine("------ start sub functuion ------\n");
        }
    }
}
