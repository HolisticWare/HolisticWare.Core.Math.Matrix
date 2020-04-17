using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// https://github.com/dotnet/runtime/blob/master/src/libraries/System.Numerics.Vectors/ref/System.Numerics.Vectors.cs
    public partial class Vector<T>
        //where T :
        //    struct,
        //    IComparable,
        //    IComparable<T>,
        //    IConvertible,       // netstandard1.3
        //    IEquatable<T>,
        //    IFormattable
    {
        protected int length;

        public int Length
        {
            get
            {
                return this.data.Length;
            }
            protected set
            {
                length = value;
            }
        }

        /// <summary>
        /// Data
        /// </summary>
        public T[] Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        protected T[] data;

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }


        protected Vector()
        {
            data_initializer = null;
            data = new T[length];

            return;
        }

        /// <summary>
        /// Constructor
        /// By default 1x1 - scalar
        /// </summary>
        /// <param name="size">Size of the vector</param>
        public Vector(int size = 1)
        {
            data_initializer = null;

            length = size;
            data = new T[length];

            return;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="size">Size of the vector</param>
        public Vector(T value, int size = 1) : this(size)
        {
            for (int i = 1; i <= size; i++)
            {
                Data[i - 1] = value;
            }

            return;
        }

        /// <summary>
        /// Vector output (C# frinedly)
        /// </summary>
        /// <returns>Vector as C# friendly string </returns>
        public override string ToString()
        {
            string name = this.GetType().Name;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("vector[] = { ");
            for (int i = 0; i < this.Length; i++)
            {
                sb.Append($"{this.Data[i]} ,");
            }
            sb.Append("};");

            return sb.ToString();
        }
    }
}
