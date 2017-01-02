using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    interface MyIList<T>
    {
        void Add(T elem);
        void Remove(T elem);
        T this[int i] { get; set; }
    }
}
