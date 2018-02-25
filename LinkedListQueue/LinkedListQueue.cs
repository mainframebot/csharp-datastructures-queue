using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListQueue
{
    public class LinkedListQueue<T> : IEnumerable<T>
    {
        private LinkedList<T> _linkedList = new LinkedList<T>();
        
        public int Count { get { return _linkedList.Count; } }

        public void Enqueue(T value)
        {
            _linkedList.AddLast(value);
        }

        public T Dequeue()
        {
            if(Count == 0)
                throw new IndexOutOfRangeException();

            T value = _linkedList.First.Value;
            _linkedList.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if(Count == 0)
                throw new IndexOutOfRangeException();

            return _linkedList.First.Value;
        }

        public void Clear()
        {
            _linkedList.Clear();
        }

        #region IEnumerable Interface Implementation

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        #endregion

    }
}
