using System;
using System.Collections.Generic;

namespace Core.Math.Matrixes.Generics.ImplementationMemory
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays"/>
    /// <typeparam name="T"></typeparam>
    public partial class Matrix<T>
    {
        public static Func<T, T, T> Addition;

        //----------------------------------------------------------------------------------------
        public Matrix<T> Add(Matrix<T> i)
        {
            return new Matrix<T>();
        }
        //----------------------------------------------------------------------------------------
        public static
                Matrix<T>
                operator +
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

            Matrix<T> result;

            switch (typeof(T))
            {
                case Type int_type when int_type == typeof(int):
                    {
                        Matrix<int> lhs1 = (Matrix<int>)Convert.ChangeType(lhs, typeof(Matrix<int>));
                        Matrix<int> rhs1 = (Matrix<int>)Convert.ChangeType(rhs, typeof(Matrix<int>));
                        result = (Matrix<T>)Convert.ChangeType(Add(lhs1, rhs1), typeof(Matrix<T>));
                        break;
                    }
                case Type double_type when double_type == typeof(double):
                    {
                        Matrix<double> lhs1 = (Matrix<double>)Convert.ChangeType(lhs, typeof(Matrix<double>));
                        Matrix<double> rhs1 = (Matrix<double>)Convert.ChangeType(rhs, typeof(Matrix<double>));
                        result = (Matrix<T>)Convert.ChangeType(Add(lhs1, rhs1), typeof(Matrix<T>));
                        break;
                    }
                default:
                    throw new NotImplementedException();
            }

            return result;
        }

        private static
                Matrix<int>
                Add
                    (
                        Matrix<int> lhs,
                        Matrix<int> rhs
                    )
        {
            int lhs_rc = lhs.CountRows;
            int lhs_cc = lhs.CountColumns;
            Matrix<int> result = new Matrix<int>(lhs_rc, lhs_cc);

            for (int r = 1; r <= lhs_rc; r++)
            {
                for (int c = 1; c <= lhs_cc; c++)
                {
                    result[r, c] = lhs[r, c] + rhs[r, c];
                }
            }

            return result;
        }

        private static
                Matrix<double>
                Add
                    (
                        Matrix<double> lhs,
                        Matrix<double> rhs
                    )
        {
            int lhs_rc = lhs.CountRows;
            int lhs_cc = lhs.CountColumns;
            Matrix<double> result = new Matrix<double>(lhs_rc, lhs_cc);

            for (int r = 1; r <= lhs_rc; r++)
            {
                for (int c = 1; c <= lhs_cc; c++)
                {
                    result[r, c] = lhs[r, c] + rhs[r, c];
                }
            }

            return result;
        }
        //----------------------------------------------------------------------------------------


    }
}
