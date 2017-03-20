using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    interface MyIDictionary<K, T>
    {
        void Put(K key, T elem);
        void Remove(K key);
        bool Contains(K key);
        T this[K key]{get;set;}
    }
}
