using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Square s = new Square(10);
            Square s1 = new Square(8);

            Console.WriteLine(c.CompareTo(s));
            Console.WriteLine(c.CompareTo(s1));

        }
    }
}
