using System;

namespace Core.Math.Matrixes.Generics.ImplementationArray
{
    /// <summary>
    ///
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T> where T : System.INumber<T>
    {
        T[,] vals;

        public int Rows { get; }
        public int Columns { get; }
        public Matrix(int rows, int columns)
        {
            Rows = rows; this.Columns = columns;
            vals = new T[rows, columns];
        }

        public Matrix(int rows, int columns, params T[] values)
        {
            Rows = rows; this.Columns = columns;
            vals = new T[rows, columns];
            for (var i = 0; i < Rows; ++i)
                for (var j = 0; j < this.Columns; ++j)
                    vals[i, j] = values[i * this.Columns + j];

        }

        public T this[int row, int column]
        {
            get => vals[row, column];
            set => vals[row, column] = value;
        }

        public static Vector<T> operator *(Matrix<T> m, Vector<T> v)
        {
            Trace.Assert(m.Columns == v.Dimension);
            var v2 = new Vector<T>(v.Dimension);
            for (var i = 0; i < m.Rows; ++i)
                for (var j = 0; j < m.Columns; ++j)
                    v2[i] += m[i, j] * v[j];
            return v2;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Rows; ++i)
            {
                sb.Append("[");
                for (var j = 0; j < Columns; ++j)
                    sb.Append($"{vals[i, j]},");
                sb.AppendLine("]");
            }
            return sb.ToString();
        }

    }
}
