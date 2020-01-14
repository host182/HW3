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

        public Shapes()
        {
            ShapeArray = new Shape[0];
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
            //set ShapeArray to be equal to s so that ShapeEnumerator.ShapeArray = Shape.ShapeArray
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


    #region ComparableShape defination: Includes ComparableShapesEnumerator
    //enumerable and enumerator classes for ComparableShapes
    class ComparableShapes
    {
        private Shape[] ShapeArray;

        public ComparableShapes(Shape[] s)
        {
            ShapeArray = new Shape[s.Length];
            for (int i = 0; i < ShapeArray.Length; ++i)
            {
                if (i > 0)
                {
                    try
                    {
                        ShapeArray[i-1].CompareTo(s[i]);
                    }
                    catch(ArgumentException)
                    {
                        throw new InvalidCastException("The two objects in the array are not comparable");
                    }

                }
                ShapeArray[i] = s[i];
            }
        }

        public ComparableShapes()
        {
            ShapeArray = new Shape[0];
        }

        public IEnumerator GetEnumerator()
        {
            return new ShapeEnumerator(ShapeArray);
        }

        public void insertIntoArray(Shape newShape, int index)
        {
            if (index < 0 || index >= ShapeArray.Length)
                throw new IndexOutOfRangeException(index + " exceeds the allocated memory bounds. Array size: " + ShapeArray.Length);
            try
            {
                ShapeArray[0].CompareTo(newShape);
            }
            catch(ArgumentException)
            {
                throw new InvalidOperationException("The given object is not comparable to object in the container. Cannot insert the given object.");
            }
        }

    }



    class ComparableShapeEnumerator : IEnumerator
    {
        public Shape[] ShapeArray
        {
            get;
            set;
        }
        private int position = -1;

        public ComparableShapeEnumerator(Shape[] s)
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
    #endregion
}

