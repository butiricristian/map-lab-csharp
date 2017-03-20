using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    interface MyIStack<T>
    {
        void Add(T elem);
        T Pop();
        bool IsEmpty();
    }
}
