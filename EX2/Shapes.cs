using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX1;

namespace EX2
{
    //enumerable and enumerator classes for Shapes
    class Shapes : IEnumerable
    {
        public Shape[] ShapeArray
        {
            get;
            set;
        }

        public Shapes(Shape[] s)
        {
            ShapeArray = new Shape[s.Length];
            for (int i = 0; i < ShapeArray.Length; ++i)
            {
                ShapeArray[i] = s[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ShapeEnumerator(ShapeArray);
        }

    }

    class ShapeEnumerator : IEnumerator
    {
        public Shape[] ShapeArray
        {
            get;
            set;
        }
        private int position = -1;

        public ShapeEnumerator(Shape[] s)
        {
            ShapeArray = s;

        }

        public object Current
        {
            get
            {
                try
                {
                    return ShapeArray[position];
                }
                catch (IndexOutOfRangeException e)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            ++position;
            return position < ShapeArray.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }


    //enumerable and enumerator classes for ComparableShapes
    class ComparableShapes
    {
        
    }
}
