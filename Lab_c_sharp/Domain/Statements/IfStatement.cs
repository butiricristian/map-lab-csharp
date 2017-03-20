using Lab_c_sharp.Domain.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class IfStatement : IStatement
    {
        Expression exp;
        IStatement ifStmt, elseStmt;

        public IfStatement(Expression exp, IStatement ifStmt, IStatement elseStmt)
        {
            this.exp = exp;
            this.ifStmt = ifStmt;
            this.elseStmt = elseStmt;
        }

        public PrgState execute(PrgState crtPrg)
        {
            if(exp.evaluate(crtPrg.SymTable) != 0)
            {
                crtPrg.ExeStack.Add(ifStmt);
            }
            else
            {
                crtPrg.ExeStack.Add(elseStmt);
            }
            return null;
        }

        public override string ToString()
        {
            return "if(" + exp.ToString() + ") then(" + ifStmt.ToString() + ") else(" + elseStmt + ")";
        }
    }
}
