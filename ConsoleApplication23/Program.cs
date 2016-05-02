using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Complex
    {
        private double re;
        private double im;

        public double Re() { return this.re; }
        public void Re(double x) { this.re = x; }

        public double Im() { return this.im; }
        public void Im(double y) { this.im = y; }

        public double Abs() { return Math.Sqrt(re * re + im * im); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex();
            x.Re(5);
            x.Im(1);

            Complex y = new Complex();
            y.Re(-2);
            y.Im(3);

            Complex z = new Complex();
            z.Re(x.Re() + y.Re());
            z.Im(x.Im() + y.Im());

            Console.WriteLine("|{0} + {1}i| = {2}", z.Re(), z.Im(), z.Abs());
        }
    }
}
