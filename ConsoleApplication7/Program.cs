using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new { FamiliyName = "Lennon", FirstName = "John" };
            Console.WriteLine("{0}{1}", x.FamiliyName, x.FirstName);
        }
    }
}
