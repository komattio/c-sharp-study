using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    //class Complex
    //{
    //    private double re;
    //    private double im;

    //    // 実部の取得・変更用のプロパティ
    //    public double Re
    //    {
    //        set { this.re = value; }
    //        get { return this.re; }
    //    }

    //    // 虚部の取得・変更用のプロパティ
    //    public double Im
    //    {
    //        set { this.im = value; }
    //        get { return this.im; }
    //    }

    //    // 絶対値の取得用のプロパティ
    //    public double Abs
    //    {
    //        get { return Math.Sqrt(re * re + im * im); }
    //    }

    //}

    class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public double Abs
        {
            get { return Math.Sqrt(Re * Re + Im * Im); }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex();
            c.Re = 4;
            c.Im = 3;
            Console.Write("|{0} + ", c.Re);
            Console.Write("{0}i| = ", c.Im);
            Console.Write(" {0}\n", c.Abs);
        }
    }
}
