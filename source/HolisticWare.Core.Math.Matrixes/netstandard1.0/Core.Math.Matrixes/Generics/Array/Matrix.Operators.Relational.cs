using System;
using System.Collections.Generic;

namespace Core.Math.Matrixes.Generics.ImplementationArray
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <typeparam name="T"></typeparam>
    public partial class Matrix<T>
    {
        //----------------------------------------------------------------------------------------
        public static
                bool
                                        operator ==
                                            (
                                                Matrix<T> lhs,
                                                Matrix<T> rhs
                                            )
        {
            if (lhs == null || rhs == null)
            {
                throw new Exception("Cannot compare null");
            }

            int lhs_rc = lhs.CountRows;
            int rhs_rc = lhs.CountRows;
            int lhs_cc = lhs.CountColumns;
            int rhs_cc = lhs.CountColumns;

            if (lhs_rc != rhs_rc || lhs_cc != rhs_cc)
            {
                throw new Exception("Matrices must be of the same size");
            }

            bool is_equal = false;

            for (int r = 1; r <= lhs.CountRows; r++)
            {
                for (int c = 1; c <= lhs.CountColumns; c++)
                {
                    if (EqualityComparer<T>.Default.Equals(lhs[r, c], rhs[r, c]))
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
        //----------------------------------------------------------------------------------------

    }
 }
