using Lab_c_sharp.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.ADT
{
    class MyDictionary<K, T> : MyIDictionary<K, T>
    {
        Dictionary<K, T> dict { get; set; }

        public MyDictionary(Dictionary<K, T> dict)
        {
            this.dict = dict;
        }

        public bool Contains(K key)
        {
            return dict.ContainsKey(key);
        }

        public T this[K key]
        {
            get { 
                if (dict.ContainsKey(key))
                    return dict[key];
                else
                    throw new KeyNotExistsException("This key does not exist!");
            }
            set {
                if (dict.ContainsKey(key))
                    dict[key] = value;
                else
                    throw new KeyNotExistsException("This key does not exist!");
            }
        }

        public void Put(K key, T elem)
        {
            if (!dict.ContainsKey(key))
                dict.Add(key, elem);
            else if (key == null)
                throw new NullKeyException("Invalid key provided!");
            else
                dict[key] = elem;
        }

        public void Remove(K key)
        {
            if(dict.ContainsKey(key))
                dict.Remove(key);
            else
                throw new KeyNotExistsException("This key does not exist!");
        }

        public override string ToString()
        {
            string res = "[ ";
            foreach(KeyValuePair<K, T> pair in dict)
            {
                res += pair.Key + "->" + pair.Value.ToString() + ", ";
            }
            res += "]";
            return res;
        }
    }
}
