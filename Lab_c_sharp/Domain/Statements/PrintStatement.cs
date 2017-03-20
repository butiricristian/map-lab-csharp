using Lab_c_sharp.Domain.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class PrintStatement : IStatement
    {
        Expression exp;

        public PrintStatement(Expression exp)
        {
            this.exp = exp;
        }

        public PrgState execute(PrgState crtPrg)
        {
            crtPrg.OutTable.Add(exp.evaluate(crtPrg.SymTable).ToString());
            return null;
        }

        public override string ToString()
        {
            return "print(" + exp.ToString() + ")";
        }
    }
}
