using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public void Print()
        {
            Console.WriteLine($"Key: {Key}, Value: {Value}");
        }
    }
}
