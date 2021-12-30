using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading#overloadable-operators
    public partial class Vector<T>
    {
        public static Vector<int> operator +(Vector<T> lhs, int rhs)
        {
            Vector<int> result = new Vector<int>();

            for (int i = 0; i < lhs.Data.Length; i++)
            {
                // int product = lhs.Data[i] * rhs;
            }
            return new Vector<int>();
        }

        //-------------------------------------------------------------------------------------------------------------
        // + int
        public static Vector<int> operator +(Vector<T> lhs, Vector<int> rhs)
        {
            return lhs.Add(rhs);
        }

        public Vector<int> Add(Vector<int> rhs)
        {
            if (this.Length != rhs.Length)
            {
                throw new System.InvalidOperationException("Vectors must be the same size!");
            }

            int length = this.Length;
            int[] tmp_data = new int[length];

            for (int i = 0; i < length; i++)
            {
                int? l = this.Data[i] as int?;
                int r = rhs.Data[i];
                tmp_data[i] = r + l.Value;
            }

            Vector<int> vector_result = new Vector<int>(length);
            vector_result.Data = tmp_data;

            return vector_result;
        }
        //-------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------------
        // + uint
        public static Vector<uint> operator +(Vector<T> lhs, Vector<uint> rhs)
        {
            return lhs.Add(rhs);
        }

        public Vector<uint> Add(Vector<uint> rhs)
        {
            if (this.Length != rhs.Length)
            {
                throw new System.InvalidOperationException("Vectors must be the same size!");
            }

            int length = this.Length;
            uint[] tmp_data = new uint[length];

            for (int i = 0; i < length; i++)
            {
                uint? l = this.Data[i] as uint?;
                uint r = rhs.Data[i];
                tmp_data[i] = r + l.Value;
            }

            Vector<uint> vector_result = new Vector<uint>(length);
            vector_result.Data = tmp_data;

            return vector_result;
        }
        //-------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------------------
        // + uint
        public static Vector<double> operator +(Vector<T> lhs, Vector<double> rhs)
        {
            return lhs.Add(rhs);
        }

        public Vector<double> Add(Vector<double> rhs)
        {
            if (this.Length != rhs.Length)
            {
                throw new System.InvalidOperationException("Vectors must be the same size!");
            }

            int length = this.Length;
            double[] tmp_data = new double[length];

            for (int i = 0; i < length; i++)
            {
                double? l = this.Data[i] as double?;
                double r = rhs.Data[i];
                tmp_data[i] = r + l.Value;
            }

            Vector<double> vector_result = new Vector<double>(length);
            vector_result.Data = tmp_data;

            return vector_result;
        }
        //-------------------------------------------------------------------------------------------------------------

    }
}
