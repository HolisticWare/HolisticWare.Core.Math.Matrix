using System;
namespace Core.Math.MatrixTheory.Reflection
{
    public partial class Matrix
    {
        public Matrix
                    (
                        Type type,
                        int count_rows = 1,
                        int count_columns = 1
                    )
        {
            this.CountRows = count_rows;
            this.CountColumns = count_columns;
            this.IsZeroBased = false;


            this.data = new Type[count_rows * count_columns];

            return;
        }

        // trying to mimic generics to work around some limitations of generics
        // int[], double[], ...
        protected Type[] data;

        public Type Type
        {
            get;
            set;
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
