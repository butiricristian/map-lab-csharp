using Lab_c_sharp.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    class MyFileTable<T> : MyIFileTable<T>
    {
        Dictionary<int, T> dict { get; set; }
        int fileDescr;

        public MyFileTable(Dictionary<int, T> dict)
        {
            this.dict = dict;
            fileDescr = 1;
        }

        public bool Contains(int key)
        {
            return dict.ContainsKey(key);
        }

        public T this[int key]
        {
            get
            {
                if (dict.ContainsKey(key))
                    return dict[key];
                else
                    throw new KeyNotExistsException("This key does not exist!");
            }
            set
            {
                if (dict.ContainsKey(key))
                    dict[key] = value;
                else
                    throw new KeyNotExistsException("This key does not exist!");
            }
        }

        public int Add(T elem)
        {
            if (!dict.ContainsKey(fileDescr))
            {
                dict.Add(fileDescr, elem);
                fileDescr++;
                return fileDescr - 1;
            }
            else
                throw new KeyAlreadyExistsException("The provided key already exists");
        }

        public void Remove(int key)
        {
            if (dict.ContainsKey(key))
                dict.Remove(key);
            else
                throw new KeyNotExistsException("This key does not exist!");
        }

        public override string ToString()
        {
            string res = "{ ";
            foreach (KeyValuePair<int, T> pair in dict)
            {
                res += pair.Key + "->" + pair.Value.ToString() + ", ";
            }
            res += "}";
            return res;
        }

        public Dictionary<int, T>.ValueCollection getValues()
        {
            return dict.Values;
        }

        public bool ContainsValue(T elem)
        {
            return dict.ContainsValue(elem);
        }
    }
}
