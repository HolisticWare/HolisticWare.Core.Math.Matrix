using System;

namespace Core.Math.Matrixes.Generics.Implementation.Memory
{
    public partial class Matrix<T>
    {
        Memory<T> data;

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        public T this[int row, int column]
        {
            get
            {
                int index = (row - 1) * CountColumns + (column - 1);

                return data.Span[index];
            }

            set
            {
                int index = (row - 1) * CountColumns + (column - 1);

                data.Span[index] = value;

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
