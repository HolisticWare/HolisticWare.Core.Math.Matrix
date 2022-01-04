using System.Text;

namespace Core.Math.Matrixes.Generic.Implementation.Vectors.Arrays
{
    public partial class Vector<T>
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"({this.data[0]}");

            for (var i = 1; i < this.Dimension; ++i)
            {
                sb.Append($",{this.data[i]}");
            }

            sb.Append(")");

            return sb.ToString();
        }

    }
}
