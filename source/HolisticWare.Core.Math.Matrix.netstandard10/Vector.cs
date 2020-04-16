using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    public partial class Vector<T>
    {
        T[] data;
        int vector_size = 0;

        protected Vector()
        {
            data_initializer = null;
            data = new T[vector_size];

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

            vector_size = size;
            data = new T[vector_size];

            return;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">Initial value</param>
        /// <param name="size">Size of the vector</param>
        public Vector(T value, int size = 1) : this(size)
        {
            for(int i = 1; i <= size; i++)
            {
                data[i - 1] = value;
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
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append($"{data[i]} ,");
            }
            sb.Append("};");

            return sb.ToString();
        }

        public static Vector<int> Add(Vector<int> lhs, Vector<int> rhs)
        {
            if (lhs.data.Length != rhs.data.Length)
            {
                throw new System.InvalidOperationException("Vectors must be the same size!");
            }

            int length = lhs.data.Length;
            int[] tmp_data = new int[length];

            for (int i = 0; i < length; i++)
            {
                tmp_data[i] = lhs.data[i] + rhs.data[i];
            }

            Vector<int> vector_result = new Vector<int>(length);
            vector_result.data = tmp_data;

            return vector_result;
        }

    }

}
