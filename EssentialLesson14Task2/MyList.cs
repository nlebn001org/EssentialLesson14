using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialLesson14Task2
{
    class MyList<T> : IEnumerable<T>
    {
        List<T> list = new List<T>();

        public int Count { get => list.Count; }

        public T this [int index]
        {
            get => list[index];
            set => list.Insert(index, value);
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public void Clear()
        {
            list.Clear();
        }


        public IEnumerator<T> GetEnumerator()
        {
           return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

