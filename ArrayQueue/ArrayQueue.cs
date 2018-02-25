using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayQueue
{
    public class ArrayQueue<T> : IEnumerable<T>
    {
        private T[] _array = new T[0];

        private int _size = 0;

        private int _head = 0;

        private int _tail = -1;

        public int Count { get { return _size; } }

        public void Enqueue(T value)
        {
            if (_size == _array.Length)
            {
                var newLength = _size == 0 ? 10 : _size * 2;
                var newArray = new T[newLength];

                if (_size > 0)
                {
                    var counter = 0;

                    if (_tail < _head)
                    {
                        for (int i = _head; i < _array.Length; i++)
                        {
                            newArray[counter] = _array[i];
                            counter++;
                        }

                        for (int i = 0; i <= _tail; i++)
                        {
                            newArray[counter] = _array[i];
                            counter++;
                        }
                    }
                    else
                    {
                        for (int i = _head; i <= _tail; i++)
                        {
                            newArray[counter] = _array[i];
                            counter++;
                        }
                    }

                    _head = 0;
                    _tail = counter - 1;
                }
                else
                {
                    _head = 0;
                    _tail = -1;
                }

                _array = newArray;    
            }

            if (_tail == _array.Length - 1)
            {
                _tail = 0;
            }
            else
            {
                _tail++;
            }

            _array[_tail] = value;
            _size++;
        }

        public T Dequeue()
        {
            if(Count == 0)
                throw new IndexOutOfRangeException();

            T value = _array[_head];
            _array[_head] = default(T);

            if (_head == _array.Length - 1)
            {
                _head = 0;
            }
            else
            {
                _head++;
            }

            _size--;

            return value;
        }

        public T Peek()
        {
            if(Count == 0)
                throw new IndexOutOfRangeException();

            return _array[_head];
        }

        public void Clear()
        {
            _size = 0;
            _head = 0;
            _tail = -1;  
            _array = new T[0];
        }

        #region IEnumerable Interface Implementation

        public IEnumerator<T> GetEnumerator()
        {
            if (_size > 0)
            {
                if (_tail < _head)
                {
                    for (int i = _head; i < _array.Length; i++)
                    {
                        yield return _array[i];
                    }

                    for (int i = 0; i <= _tail; i++)
                    {
                        yield return _array[i];
                    }
                }
                else
                {
                    for (int i = _head; i <= _tail; i++)
                    {
                        yield return _array[i];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

    }
}
