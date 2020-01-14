using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX1;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes1 = new Shape[3];
            shapes1[0] = new Square(5, "red");
            shapes1[1] = new Circle(5, "blue");
            shapes1[2] = new Pentagon(5, "green");

            Shape[] shapes2 = new Shape[2];
            shapes2[0] = new Square(10, "amber");
            shapes2[1] = new Pentagon(3, "brown");

            Console.WriteLine("FOREACH SHAPES");
            Shapes shapeCollection = new Shapes(shapes1);
            int i = 0;
            foreach(Shape s in shapeCollection)
            {
                Console.WriteLine(i + " " + s.Color);
                ++i;
            }


            ComparableShapes compShapes = new ComparableShapes();
            try
            {
                compShapes = new ComparableShapes(shapes2);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("FOREACH COMPARABLESHAPES");
            i = 0;
            foreach(Shape s in compShapes)
            {
                Console.WriteLine(i + " " + s.Color);
                ++i;
            }


            Console.WriteLine("SHOULD THROW AN EXCEPTION: INSTANTIATING USING INCOMPARABLE OBJECTS");
            try
            {
                ComparableShapes compShapes2 = new ComparableShapes(shapes1);
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("SHOULD THROW AN EXCEPTION: INSERTING CIRCLE");
            Circle c = new Circle(4, "white");
            try
            {
                compShapes.insertIntoArray(c, 1);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
