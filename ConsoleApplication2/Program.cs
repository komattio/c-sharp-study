using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;

            Console.Write("身長[cm]: ");
            height = double.Parse(Console.ReadLine());
            height *= 0.01;

            Console.Write("体重[kg]: ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            Console.Write("BMI = {0}\n", bmi);
        }
    }
}
