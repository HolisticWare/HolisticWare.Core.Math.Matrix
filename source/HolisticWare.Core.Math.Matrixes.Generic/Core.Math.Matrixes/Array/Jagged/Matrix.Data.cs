using System;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.Jagged
{
    public partial class Matrix<T>
    {
        T[,] data;

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
                return data[row, column];
            }

            set
            {
                data[row, column] = value;

                return;
            }
        }

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
