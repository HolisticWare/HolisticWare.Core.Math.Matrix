using System;

namespace Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays
{
    /// <summary>
    ///
    /// </summary>
    /// https://en.wikipedia.org/wiki/Vector_(mathematics_and_physics)
    /// https://en.wikipedia.org/wiki/Row_and_column_vectors
    /// https://en.wikipedia.org/wiki/Euclidean_vector
    ///
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading"/>
    /// <typeparam name="T"></typeparam>
    public partial class Vector<T>
        where T
        :
            INumber<T>,
            IComparisonOperators<T, T>      // implies IEquatableOperators<TSelf, TSelf>
    {
        public
                                        Vector
                                            (
                                                int size = 1,
                                                T value = default(T)
                                            )
        {
            this.data = new T[size];

            return;
        }

        public
                                        Vector
                                            (
                                                int size = 1,
                                                params T[] values
                                            )
        {
            this.data = new T[size];

            Array.Copy(values, this.data, size);

            return;
        }
    }
}
