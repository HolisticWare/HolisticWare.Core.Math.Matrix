using System.Text;

namespace Core.Math.Matrixes.Generics.Implementation.Arrays.Jagged
{
    public partial class Matrix<T>
    {
        public override
            string
                                        ToString
                                            (
                                            )
        {
            StringBuilder sb = new StringBuilder();

            for (var i = 0; i < this.CountRows; ++i)
            {
                sb.Append("[");
                for (var j = 0; j < this.CountColumns; ++j)
                {
                    sb.Append($"{this.data[i, j]},");
                }
                sb.AppendLine("]");
            }
            return sb.ToString();
        }

    }
}
