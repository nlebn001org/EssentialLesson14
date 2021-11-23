using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialLesson14Task3
{
    class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        public int Count { get => dict.Count; }

        public (TKey, TValue) this[int index] 
        {
            get => (dict.Keys.ToList()[index], dict.Values.ToList()[index]);
        }

        public void Add(TKey key, TValue value)
        {
            dict.Add(key, value);
        }



        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
