using System;

namespace Core.Math.Matrixes.Generics.ImplementationArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public partial class Matrix<T>
    {
        T[] data;

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
        public T this[int row, int column]
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

        public bool IsZeroBased
        {
            get;
            set;
        }

    }
}
