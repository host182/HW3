using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Shape:IComparable
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

        public int CompareTo(object o)
        {
            if (o == null)
            {
                return -1;
            }
            Shape newObject = o as Shape;
            if (newObject != null)
            {
                return getArea().CompareTo(newObject.getArea());
            }
            else
            {
                throw new ArgumentException("Object is not a Shape");
            }
            return 0;
        }
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
    }

    class EqPolygon : Shape
    {
        public int SideLen
        {
            get;
            set;
        }

        public EqPolygon(int len = 0, string c = "") : base(c) { SideLen = len; }

    }

    class Triangle : EqPolygon
    {
        public Triangle(int len = 0, string c = "") : base(len, c) { }
        public override double getPerimeter() { return 3 * SideLen; }

        public override double getArea()
        {
            return Math.Pow(3, 0.5) * SideLen * SideLen / 4;
        }
    }

    class Square : EqPolygon
    {
        public Square(int len = 0, string c = "") : base(len, c) { }
        public override double getPerimeter() { return 4 * SideLen; }

        public override double getArea()
        {
            return SideLen * SideLen;
        }
    }

    class Pentagon : EqPolygon
    {
        public Pentagon(int len = 0, string c = "") : base(len, c) { }
        public override double getPerimeter() { return 5 * SideLen; }

        public override double getArea()
        {
            return Math.Pow(5 * (5 + 2 * Math.Pow(5, 0.5)), 0.5) * SideLen * SideLen / 4;
        }
    }
}
