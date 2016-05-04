using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("base constractor called");
        }
    }

    class Deriverd : Base
    {
        public Deriverd()
        {
            Console.WriteLine("derived constractor called");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // 派生クラスのインスタンスが生成される際、派生クラスのコンストラクタが
            // 呼び出される前に、基底クラスのコンストラクタが呼び出される
            Deriverd d = new Deriverd();
        }
    }
}
