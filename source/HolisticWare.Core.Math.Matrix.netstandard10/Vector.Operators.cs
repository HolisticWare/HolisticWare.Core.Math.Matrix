using System;
using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading#overloadable-operators
    public partial class Vector<T>
    {
        public static Vector<int> operator+(Vector<T> lhs, Vector<int> rhs)
        {
            return lhs.Add(rhs);
        }

        public static Vector<int> operator +=(Vector<int> rhs)
        {
            return this + rhs;
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
    }

}
