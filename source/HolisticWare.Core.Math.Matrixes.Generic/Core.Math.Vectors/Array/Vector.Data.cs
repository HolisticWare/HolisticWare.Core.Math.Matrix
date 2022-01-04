using System;

namespace Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays
{
    public partial class Vector<T>
    {
        protected T[] data;

        public
            T
                                        this
                                            [
                                                int index
                                            ]
        {
            get
            {
                return data[index];
            }

            set
            {
                data[index] = value;

                return;
            }
        }

        public int Dimension
        {
            get
            {
                return data.Length;
            }
        }

        protected Type vector_type;
        public Type VectorType
        {
            get
            {
                return vector_type;
            }

            set
            {
                vector_type = value;

                return;
            }
        }

        public enum Type
        {
            Column,
            Row
        }

    }
}
