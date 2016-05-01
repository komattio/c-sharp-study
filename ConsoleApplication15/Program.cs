using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14;
            int n = 99;
            string s = "test string";
            bool b = true;

            Write("x = {0}, n = {1}, s = {2}, b = {3}\n", x, n, s, b);
        }

        static void Write(string format, params object[] args)
        {
            for(int i=0; i<args.Length; ++i)
            {
                format = format.Replace("{" + i.ToString() + "}", args[i].ToString());
            }
            Console.Write(format);
        }
    }
}
