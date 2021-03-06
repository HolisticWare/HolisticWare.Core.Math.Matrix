﻿using System.Collections;
using System.Collections.Generic;

namespace Core.Math.Matrix
{
    /// <see href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers"/>
    /// <see href=""/>
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


        List<T> data_initializer = new List<T>();

        public void Add(T value)
        {
            if (data_initializer == null)
            {
                data_initializer = new List<T>();
            }
            data_initializer.Add(value);

            data = data_initializer.ToArray();

            return;
        }
    }
}
