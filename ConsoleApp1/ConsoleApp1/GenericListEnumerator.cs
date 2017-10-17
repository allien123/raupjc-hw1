using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{
    internal class GenericListEnumerator<X> : IEnumerator<X>
    {
        private GenericList<X> genericList;
        private int _currentIndex;

        public GenericListEnumerator(GenericList<X> genericList)
        {
            this.genericList = genericList;
        }

        public void Dispose()
        {
            Current = default(X);
        }

        public bool MoveNext()
        {
            if (_currentIndex < genericList.Count)
            {
                Current = genericList.GetElement(_currentIndex);
                _currentIndex++;
                return true;
            };
            return false;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

        public X Current { get; private set; }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}