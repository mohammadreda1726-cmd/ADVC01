using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    public class Container <T>
    {
        public T value;
        public void Add(T item)
        {
            value = item;
        }

        public T Get()
        {
            return value;
        }

    }
}
