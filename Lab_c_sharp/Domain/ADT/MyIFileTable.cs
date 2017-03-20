using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    interface MyIFileTable<T>
    {
        int Add(T elem);
        void Remove(int key);
        bool Contains(int key);
        T this[int key] { get; set; }
        Dictionary<int, T>.ValueCollection getValues();
        bool ContainsValue(T elem);
    }
}
