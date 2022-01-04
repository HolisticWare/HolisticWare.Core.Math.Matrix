using System;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.SingleDimensional
{
    /// <summary>
    ///
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public partial class Matrix<T>
        where T : System.INumber<T>
    {
        // ctor
        // default 1x1 scalar as Matrix
        // see implicit conversion operator
        public
                                        Matrix
                                            (
                                                int count_rows = 1,
                                                int count_columns = 1,
                                                T value_default = default(T)
                                            )
        {
            this.CountRows = count_rows;
            this.CountColumns = count_columns;
            data = new T[count_rows * count_columns];

            return;
        }

        public
                                        Matrix
                                            (
                                                int count_rows,
                                                int count_columns,
                                                params T[] values
                                            )
        {
            this.CountRows = count_rows;
            this.CountColumns = count_columns;

            this.data = new T[count_rows * count_columns];

            for (int i = 0; i < CountRows; ++i)
            {
                for (int j = 0; j < this.CountRows; ++j)
                {
                    int idx = i * this.CountColumns + j;

                    this.data[idx] = values[idx];
                }
            }

            return;
        }
    }
}
