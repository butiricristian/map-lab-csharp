using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_c_sharp.Domain.ADT;

namespace Lab_c_sharp.Domain.Expressions
{
    class VarExpression : Expression
    {
        string varName;

        public VarExpression(string varName)
        {
            this.varName = varName;
        }

        public override int evaluate(MyIDictionary<string, int> symTable)
        {
            return symTable[varName];
        }

        public override string ToString()
        {
            return varName;
        }
    }
}
