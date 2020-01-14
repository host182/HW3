using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Shape //: IComparable
    {
        public string Color
        {
            get;
            set;
        }
        public Shape(string c = "") { Color = c; }
        public string getColor() { return Color; }
        public void setColor(string c) { Color = c; }
        public virtual double getPerimeter() { return 0; }

        public virtual double getArea() { return 0; }

        public virtual int CompareTo(object o)
        {
            return 0;
        }
        
        //commented this function so that some shapes cannot be compared to other shapes
        //public int CompareTo(object o)
        //{
        //    if (o == null)
        //    {
        //        return 1;
        //    }
        //    Shape newObject = o as Shape;
        //    if (newObject != null)
        //    {
        //        return getArea().CompareTo(newObject.getArea());
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Object is not a Shape");
        //    }
        //}
    }

    class Circle : Shape
    {
        int radius;
        public Circle(int r = 0, string c = "") : base(c) { radius = r; }
        public int getRadius() { return radius; }
        public void setRadius(int r) { radius = r; }
        public override double getPerimeter()
        {
            return 2 * 3.1415 * radius;
        }

        public override double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override int CompareTo(object o)
        {
            if (o == null)
                return 1;
            Circle newCircle = o as Circle;
            if (newCircle == null)
                throw new ArgumentException("Object is not a circle");
            else
                return radius.CompareTo(newCircle.radius);
        }
    }

    //I set EqPolygon to inherit IComparable so that the I get an error when I try to compare with Circle
    class EqPolygon : Shape
    {
        protected int sides;

        public int SideLen
        {
            get;
            set;
        }

        public EqPolygon(int len = 0, string c = "", int s = 3) : base(c)
        {
            SideLen = len;
            sides = s;
        }

        public int getSides() { return sides; }

        public override int CompareTo(object o)
        {
            if (o == null)
                return 1;
            EqPolygon newPoly = new EqPolygon();
            try
            {
                newPoly = o as EqPolygon;
            }
            catch
            {
                Console.WriteLine("Here");
            }
            if (newPoly == null)
                throw new ArgumentException("Object is not an EqPolygon");
            else
            {
                return sides.CompareTo(newPoly.sides);
            }
        }
    }

    class Triangle : EqPolygon
    {
        public Triangle(int len = 0, string c = "") : base(len, c,3) { }
        public override double getPerimeter() { return sides * SideLen; }

        public override double getArea()
        {
            return Math.Pow(3, 0.5) * SideLen * SideLen / 4;
        }
    }

    class Square : EqPolygon
    {
        public Square(int len = 0, string c = "") : base(len, c,4) { }
        public override double getPerimeter() { return 4 * SideLen; }

        public override double getArea()
        {
            return SideLen * SideLen;
        }
    }

    class Pentagon : EqPolygon
    {
        public Pentagon(int len = 0, string c = "") : base(len, c,5) { }
        public override double getPerimeter() { return 5 * SideLen; }

        public override double getArea()
        {
            return Math.Pow(5 * (5 + 2 * Math.Pow(5, 0.5)), 0.5) * SideLen * SideLen / 4;
        }
    }
}
