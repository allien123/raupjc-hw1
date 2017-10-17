using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        public int Count { get; private set; }

        public IntegerList(int initialSize)
        {
            _internalStorage = new int[initialSize];
        }

        public IntegerList(): this(4)
        {
        }

        public void Add(int item)
        {
            if (Count == _internalStorage.Length)
            {
                reallocStorage();
            };

            _internalStorage[Count] = item;
            Count++;
        }

        private void reallocStorage()
        {
            int[] largerStorage = new int[_internalStorage.Length*2];
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                largerStorage[i] = _internalStorage[i];
            }

            _internalStorage = largerStorage;
        }

        public void Clear()
        {
            Count = 0;
        }

        public bool Contains(int item)
        {
            return IndexOf(item)!=-1;
        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            };

            return _internalStorage[index];
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return i;
                }
            };
            return -1;
        }

        public bool Remove(int item)
        {
            int index = IndexOf(item);
            return index==-1?false:RemoveAt(index);
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            };

            for (int i = index; i < Count - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }

            Count--;
            return true;
        }

    }
}
