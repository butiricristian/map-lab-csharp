using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    class MyList<T> : MyIList<T>
    {
        List<T> list{ get; set; }

        public MyList(List<T> list)
        {
            this.list = list;
        }

        public void Add(T elem)
        {
            list.Add(elem);
        }

        public void Remove(T elem)
        {
            if (list.Contains(elem))
                list.Remove(elem);
            else
                throw new KeyNotFoundException("The element does not exist");
        }

        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public override string ToString()
        {
            string res = "";
            foreach(T el in list)
            {
                res += el.ToString() + " ";
            }
            return res;
        }
    }
}
