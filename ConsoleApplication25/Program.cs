using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Product
    {
        static int id_generator;
        int id;

        static Product()
        {
            id_generator = 0;
        }

        public Product()
        {
            id = id_generator;
            id_generator++;
        }

        public int ID
        {
            get { return id; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Product p = new Product();
                Console.WriteLine("ID: {0}", p.ID);
            }
        }
    }
}
