using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    public class Box<T>
    {
        public T Value { get; set; }

        public void Show()
        {
            Console.WriteLine(Value);
        }

    }
    class IntBox : Box<int>
    {
    }
}
