using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Test
    {
        public Test()
        {
            Console.WriteLine("Testコンストラクタが呼ばれました");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mainの先頭");
            Test t = new Test();
            Console.WriteLine("Mainの末尾");
        }
    }
}
