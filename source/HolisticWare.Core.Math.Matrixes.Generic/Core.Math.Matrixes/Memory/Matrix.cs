using System;

namespace Core.Math.Matrixes.Generics.Implementation.Memory
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
        /// <summary>
        /// Matrix constructor (ctor)
        /// </summary>
        /// <param name="count_rows"></param>
        /// <param name="count_columns"></param>
        public
                                        Matrix
                                            (
                                                int count_rows = 1,
                                                int count_columns = 1
                                            )
        {
            this.CountRows = count_rows;
            this.CountColumns = count_columns;

            T[] data_array = new T[count_rows * count_columns];
            this.data = new Memory<T>(data_array, 0, count_rows * count_columns - 1);

            return;
        }

        /// <summary>
        /// Matrix copy constructor (cctor)
        /// </summary>
        /// <param name="m"></param>
        public
                                        Matrix
                                            (
                                                Matrix<T> m
                                            )
        {
            int count_rows = m.CountRows;
            int count_columns = m.CountColumns;

            this.CountRows = count_rows;
            this.CountColumns = count_columns;

            T[] data_array = new T[count_rows * count_columns];
            this.data = new Memory<T>(data_array, 0, count_rows * count_columns - 1);

            int index;

            for (int r = 1; r <= count_rows; r++)
            {
                for (int c = 1; c <= count_columns; c++)
                {
                    index = (r - 1) * CountColumns + (c - 1);
                    data.Span[index] = m[r, c];
                }
            }

            return;
        }

    }
}
