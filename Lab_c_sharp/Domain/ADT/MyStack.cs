using Lab_c_sharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    class MyStack<T> : MyIStack<T>
    {
        Stack<T> stack
        {
            get;
            set;
        }

        public MyStack(Stack<T> stack)
        {
            this.stack = stack;
        }

        public void Add(T elem)
        {
            stack.Push(elem);
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public override string ToString()
        {
            string res = "";
            foreach(T el in stack)
            {
                res += el.ToString() + "\n";
            }
            return res;
        }
    }
}
