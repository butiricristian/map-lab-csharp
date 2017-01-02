using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_c_sharp.Domain.ADT;

namespace Lab_c_sharp.Domain.Expressions
{
    class ConstExpression : Expression
    {
        int number;

        public ConstExpression(int number)
        {
            this.number = number;
        }

        public override int evaluate(MyIDictionary<string, int> symTable)
        {
            return number;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }
}
