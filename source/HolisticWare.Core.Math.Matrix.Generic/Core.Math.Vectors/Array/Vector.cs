using System;

namespace Core.Math.Matrixes.Generics.ImplementationArray
{
    /// <summary>
    ///
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public class Vector<T> where T : INumber<T>
    {
        protected T[] vals;

        public int Dimension => vals.Length;
        public Vector(int n)
        {
            vals = new T[n];
        }
        public Vector(int n, params T[] values)
        {
            vals = new T[n];
            Array.Copy(values, vals, n);
        }

        public T this[int index]
        {
            get => vals[index];
            set => vals[index] = value;
        }
        public static Vector<T> operator +(Vector<T> a, Vector<T> b)
        {
            var v = new Vector<T>(a.Dimension);
            for (var i = 0; i < a.Dimension; ++i)
                v[i] = a[i] + b[i];
            return v;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"({vals[0]}");
            for (var i = 1; i < Dimension; ++i)
                sb.Append($",{vals[i]}");
            sb.Append(")");

            return sb.ToString();
        }
    }
}
