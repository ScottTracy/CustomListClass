using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;







namespace CustomList
{
    public class CustomList<T> : IEnumerable, IEnumerator
    {
        private const int _defaultCapacity = 4;
        private T[] _items;
        private T[] arr = new T[4];
        private int size;
        private int _version;
        static readonly T[] emptyArray = new T[0];
        private int _count;

        public T this[int index]
        {
            get
            {

                if (index >= size)
                {
                    //      ThrowHelper.ThrowArgumentOutOfRangeException();
                }
                return _items[index];
            }

            set
            {
                if (index >= size)
                {
                    //    ThrowHelper.ThrowArgumentOutOfRangeException();
                }
                _items[index] = value;
                _version++;
            }
        }


        public int Count
        {
            get
            {
                while (true)
                {
                    return _count;
                }


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
                    //ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);

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
            if (size == _items.Length) EnsureCapacity(size + 1);
            _items[size++] = item;
            _version++;
            _count++;
            _count = size;
            
        }
       
        private void EnsureCapacity(int minimum)
        {
            if (_items.Length < minimum)
            {
                if (_items.Length == 0)
                {
                    Capacity = _defaultCapacity;
                }
                else
                {
                    Capacity = _items.Length * 2;
                }
            }
        }





        public bool MoveNext()
        {

            return (true);
        }


        public void Reset()
        {
        }


        public object Current
        {
            get
            {
                T current = default(T);
                return current;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public CustomList(IEnumerable<T> collection)
        {
            // if (collection == null)
            //      ThrowHelper.ThrowArgumentNullException(ExceptionArgument.collection);
            //  Contract.EndContractBlock();

            ICollection<T> c = collection as ICollection<T>;
            if (c != null)
            {
                int count = c.Count;
                if (count == 0)
                {
                    _items = emptyArray;
                }
                else
                {
                    _items = new T[count];
                    c.CopyTo(_items, 0);
                    size = count;
                }
            }
            else
            {
                size = 0;
                _items = emptyArray;
                using (IEnumerator<T> enumerator = collection.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        Add(enumerator.Current);
                    }
                }
            }
        }
        public CustomList(int capacity)
        {
            //   if (capacity < 0) ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.capacity, ExceptionResource.ArgumentOutOfRange_NeedNonNegNum);
            //   Contract.EndContractBlock();

            if (capacity == 0)
                _items = emptyArray;
            else
                _items = new T[capacity];
        }
        public CustomList()
        {
            _items = emptyArray;
        }
        public bool Remove(T item)
        {
            int index = IndexOf(_items, item, size);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }
        public static int IndexOf(T[] array, T value, int size)
        {
            int _index = 0;
            if (array == null)
            {
                //   throw new ArgumentNullException("list");
            }

            if (size < 0 || size > array.Length)
            {
                //  throw new ArgumentOutOfRangeException("count", Environment.GetResourceString("ArgumentOutOfRange_Count"));
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i], value)) return i;
                {
                    _index = i;
                }
                _index = -1;
            }
            return _index;

        }
        public void RemoveAt(int index)
        {
            if ((uint)index >= (uint)size)
            {
                // ThrowHelper.ThrowArgumentOutOfRangeException();
            }

            size--;
            if (index < size)
            {
                Array.Copy(_items, index + 1, _items, index, size - index);
            }
            _count = size;
            _version++;
        }
        public static CustomList<T> operator+ (CustomList<T> listA, CustomList<T> listB)
        { CustomList<T> _list = new CustomList<T>();
            for (int i = 0; listA.Count > i; i++)
            {
                _list.Add(listA[i]);
            }
            for (int i = 0; listB.Count > i; i++)
            {
                _list.Add(listB[i]);
            }
            return _list;


        }
        public static CustomList<T> operator -(CustomList<T> listA, CustomList<T> listB)
        {
            CustomList<T> _list = new CustomList<T>(); for (int i = 0; listA.Count > i; i++)
            {
                _list.Add(listA[i]);
            }
            for (int i = listB.Count-1; i>=0; i--)
            {
                for (int j = listA.Count - 1; j >= 0; j--)
                {
                    if (Equals(listA[j], listB[i]))
                    {
                        _list.RemoveAt(j);
                    }
                }
            }
            return _list;

        }

    }

}   
