using Lab_c_sharp.Domain.ADT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Expressions
{
    abstract class Expression
    {
        public abstract int evaluate(MyIDictionary<String, int> symTable);
    }
}
