using System;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <typeparam name="T"></typeparam>
    public partial struct Matrix<T>
            where T : IEquatable<T>
    {
        public static bool operator ==(Matrix<T> lhs, Matrix<T> rhs)
        {
            if (lhs == null || rhs == null)
            {
                throw new Exception("");
            }

            int lhs_rc = lhs.CountRows;
            int rhs_rc = lhs.CountRows;
            int lhs_cc = lhs.CountColumns;
            int rhs_cc = lhs.CountColumns;

            if( lhs_rc != rhs_rc || lhs_cc != rhs_cc )
            {
                throw new Exception();
            }

            if (lhs_rc != rhs_rc || lhs_cc != rhs_cc)
            {
                throw new Exception();
            }

            bool is_equal = false;

            for (int r = 1; r <= lhs.CountRows; r++)
            {
                for (int c = 1; c <= lhs.CountColumns; c++)
                {
                    if ( EqualityComparer<T>.Default.Equals(lhs[r, c], rhs[r, c]) )
                    {
                        is_equal = true;
                    }
                    else
                    {
                        is_equal = false;
                        break;
                    }
                }
            }

            return is_equal;
        }

        public static bool operator !=(Matrix<T> lhs, Matrix<T> rhs)
        {
            return !(lhs == rhs);
        }

        public static Matrix<T> operator +(Matrix<T> m)
        {
            Matrix<T> m_new = new Matrix<T>(m.CountRows, m.CountColumns);

            return m_new;
        }

        public static Matrix<T> operator -(Matrix<T> m)
        {
            Matrix<T> m_new = new Matrix<T>(m.CountRows, m.CountColumns);

            return m_new;
        }

    }
}
