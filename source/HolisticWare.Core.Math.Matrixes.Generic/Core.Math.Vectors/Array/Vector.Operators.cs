using System;

namespace Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays
{
    public partial class Vector<T>
    {
        public static
            bool
                                        operator ==
                                            (
                                                Vector<T> lhs,
                                                Vector<T> rhs
                                            )
        {
            // no Asserts

            if ( lhs.VectorType != rhs.VectorType )
            {
                return false;
            }

            if ( lhs.Dimension != rhs.Dimension )
            {
                return false;
            }

            bool result = true;

            for (int i = 0; i < lhs.Dimension; ++i)
            {
                result = lhs[i].Equals(rhs[i]);

                if ( result == false )
                {
                    break;
                }
            }

            return result;
        }

        public static
            bool
                                        operator !=
                                            (
                                                Vector<T> lhs,
                                                Vector<T> rhs
                                            )
        {
            return !( lhs == rhs );
        }

        public static
            Vector<T>
                                        operator +
                                            (
                                                Vector<T> lhs,
                                                Vector<T> rhs
                                            )
        {

            Vector<T> result = new Vector<T>(lhs.Dimension);

            for (int i = 0; i < lhs.Dimension; ++i)
            {
                result[i] = lhs[i] + rhs[i];
            }

            return result;
        }

        public static
            Vector<T>
                                        operator *
                                            (
                                                Vector<T> lhs,
                                                Vector<T> rhs
                                            )
        {
            Vector<T> result = new Vector<T>(lhs.Dimension);

            return result;
        }
    }
}
