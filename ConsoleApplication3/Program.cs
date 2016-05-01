using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;

            Console.Write("文字を入力してください: ");
            c = Console.ReadLine()[0];

            Console.Write("文字 {0} の文字コードは {1} \n", c, (int)c);
        }
    }
}
