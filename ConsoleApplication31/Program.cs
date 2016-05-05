using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication31
{
    delegate void SomeDelegate(int a);

    class Program
    {
        static void Main(string[] args)
        {
            SomeDelegate a = new SomeDelegate(A);

            a(256);
        }

        static void A(int n)
        {
            Console.WriteLine("A({0})", n);
        }
    }
}
