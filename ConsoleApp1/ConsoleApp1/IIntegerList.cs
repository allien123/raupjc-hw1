using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IIntegerList
    {
        void Add(int item);
        bool Remove(int item);
        bool RemoveAt(int index);
        int GetElement(int index);
        int IndexOf(int item);
        int Count { get; }
        void Clear();
        bool Contains(int item);
    }
}
