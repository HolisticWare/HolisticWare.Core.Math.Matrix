using Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.SingleDimensional
{
    public partial class Matrix<T>
    {
        public static
            Matrix<T>
                                        operator +
                                            (
                                                Matrix<T> lhs,
                                                Matrix<T> rhs
                                            )
        {
            System.Diagnostics.Trace.Assert(lhs.CountRows == lhs.CountRows);
            System.Diagnostics.Trace.Assert(lhs.CountColumns == lhs.CountColumns);

            Matrix<T> result = new Matrix<T>(lhs.CountRows, lhs.CountColumns);

            return result;
        }

        public static
            Matrix<T>
                                        operator *
                                            (
                                                Matrix<T> lhs,
                                                Matrix<T> rhs
                                            )
        {
            System.Diagnostics.Trace.Assert(lhs.CountRows == lhs.CountColumns);
            System.Diagnostics.Trace.Assert(lhs.CountColumns == lhs.CountRows);

            Matrix<T> result = new Matrix<T>(lhs.CountRows, lhs.CountColumns);

            return result;
        }

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
