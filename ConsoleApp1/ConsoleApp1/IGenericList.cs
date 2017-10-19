using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IGenericList<X>: IEnumerable<X>
    {
        void Add(X item);
        bool Remove(X item);
        bool RemoveAt(int index);
        X GetElement(int index);
        int IndexOf(X item);
        int Count { get; }
        void Clear();
        bool Contains(X item);
    }
}
