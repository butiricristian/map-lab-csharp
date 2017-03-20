using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_c_sharp.Domain.ADT;
using Lab_c_sharp.Domain.Exceptions;

namespace Lab_c_sharp.Domain.Expressions
{
    class ArithmExpression : Expression
    {
        string op;
        Expression e1, e2;

        public ArithmExpression(string op, Expression e1, Expression e2)
        {
            this.op = op;
            this.e1 = e1;
            this.e2 = e2;
        }

        public override int evaluate(MyIDictionary<string, int> symTable)
        {
            switch (op)
            {
                case "+":
                    return e1.evaluate(symTable) + e2.evaluate(symTable);
                case "-":
                    return e1.evaluate(symTable) + e2.evaluate(symTable);
                case "*":
                    return e1.evaluate(symTable) * e2.evaluate(symTable);
                case "/":
                    int e2Val = e2.evaluate(symTable);
                    if(e2Val == 0)
                    {
                        throw new DivisionBy0Exception("Division by 0!");
                    }
                    return e1.evaluate(symTable) + e2.evaluate(symTable);
                default:
                    throw new InvalidOperatorException("Invalid operator");
            }
        }

        public override string ToString()
        {
            return e1.ToString() + " " + op + " " + e2.ToString();
        }
    }
}
