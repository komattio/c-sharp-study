using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        public static int CountList<T>(List<T> list, Func<T, bool> predicate)
        {
            int count = 0;
            foreach (T element in list)
            {
                if (predicate(element))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsLengthLesThan5(string str)
        {
            return str.Length < 5;
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Taro",
                "Jiro",
                "Saburo",
                "Umeki",
                "Takeko",
                "Matsuko"
            };

            Func<string, bool> predicate = IsLengthLesThan5;
            int count = CountList(names, predicate);
            Console.WriteLine("count: {0}", count);
        }
    }
}
