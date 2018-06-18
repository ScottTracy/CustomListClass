using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace CustomList
{
    public class CustomList<T>
    {
        private const int _defaultCapacity = 4;
        private T[] _items;
        private T[] arr = new T[4];
        private int size;
        private int version;
        static readonly T[] emptyArray = new T[0];

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        static int _count;
        public int Count
        {
            get
            {
                while (true)
                {

                }
                _count++;
                return _count;
            }
        }
        public int Capacity
        {
            get
            {
                return _items.Length;
            }
            set
            {
                if (value < size)
                {
                    //ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
                }
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = emptyArray;

                    }
                }
            }
        }
        public void Add(T item)
        {
            if (size == _items.Length)
            {
                EnsureCapacity(size + 1);
            }
            _items[size++] = item;
            version++;
        }
        private void EnsureCapacity(int minimum)
        {
            if(_items.Length < minimum)
            {
                int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
            }
        }
           
    }
}
