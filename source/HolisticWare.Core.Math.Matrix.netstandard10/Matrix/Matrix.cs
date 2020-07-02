namespace Core.Math.Matrix
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public partial struct Matrix<T>
    {
        public Matrix
            (
                int count_rows = 1,
                int count_columns = 1,
                T value = default(T)
            )
        {
            CountRows = count_rows;
            CountColumns = count_columns;
            IsZeroBased = false;

            data = new T[count_rows + 1, count_columns + 1];

            return;
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

        T[,] data;

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        public T this[int row, int column]
        {
            get
            {
                return data[row, column];
            }
            set
            {
                data[row, column] = value;
            }
        }

        public bool IsZeroBased
        {
            get;
            set;
        }

    }
}
