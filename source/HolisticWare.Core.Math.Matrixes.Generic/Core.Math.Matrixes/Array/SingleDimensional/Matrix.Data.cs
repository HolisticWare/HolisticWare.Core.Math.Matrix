using System;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.SingleDimensional
{
    public partial class Matrix<T>
    {
        T[] data;

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        public
            T
                                        this
                                            [
                                                int row,
                                                int column
                                            ]
        {
            get
            {
                int index = (row - 1) * CountColumns + (column - 1);

                return data[index];
            }

            set
            {
                int index = (row - 1) * CountColumns + (column - 1);

                data[index] = value;

                return;
            }
        }

        // public T this[int row, int column]
        // {
        //     get => vals[row, column];
        //     set => vals[row, column] = value;
        // }

        public int CountRows
        {
            get;
            set;
        }

        public int CountColumns
        {
            get;
            set;
        }

    }
}
