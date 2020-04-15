using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    public partial class Vector<T>
        :
        IEnumerable<T> // needed for initializers
    {
        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T value)
        {
            List<T> data_temp = new List<T>(data);

            return;
        }
    }
}
