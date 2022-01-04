using Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.Jagged
{
    public partial class Matrix<T>
    {
        public static
            Vector<T>
                                        operator *
                                            (
                                                Matrix<T> m,
                                                Vector<T> v
                                            )
        {
            System.Diagnostics.Trace.Assert(m.CountColumns == v.Dimension);

            Vector<T> result = new Vector<T>(v.Dimension);

            for (int i = 0; i < m.CountRows; ++i)
            {
                for (int j = 0; j < m.CountColumns; ++j)
                {
                    result[i] += m[i, j] * v[j];
                }
            }

            return result;
        }

    }
}
