using System;

namespace Core.Math.Matrixes.Generics.ImplementationArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public partial class Matrix<T> : Core.Math.Matrixes.MatrixBase
    {
        public Matrix
                    (
                        int count_rows = 1,
                        int count_columns = 1
                    )
        {
            this.CountRows = count_rows;
            this.CountColumns = count_columns;
            this.IsZeroBased = false;

            this.data = new T[count_rows * count_columns];

            return;
        }

        private static int AdditionInt(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public Matrix
                    (
                        Matrix<T> m
                    )
        {
            int count_rows = m.CountRows;
            int count_columns = m.CountColumns;

            this.IsZeroBased = m.IsZeroBased;
            this.CountRows = count_rows;
            this.CountColumns = count_columns;

            this.data = new T[count_rows * count_columns];

            int index;

            for (int r = 1; r <= count_rows; r++)
            {
                for (int c = 1; c <= count_columns; c++)
                {
                    index = (r - 1) * CountColumns + (c - 1);
                    data[index] = m[r, c];
                }
            }

            return;
        }
    }
}
