using Lab_c_sharp.Domain.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class AssignStatement : IStatement
    {
        string varName;
        Expression value;

        public AssignStatement(string varName, Expression value)
        {
            this.varName = varName;
            this.value = value;
        }

        public PrgState execute(PrgState crtPrg)
        {
            if (crtPrg.SymTable.Contains(varName))
            {
                crtPrg.SymTable[varName] = value.evaluate(crtPrg.SymTable);
            }
            crtPrg.SymTable.Put(varName, value.evaluate(crtPrg.SymTable));
            return null;
        }

        public override string ToString()
        {
            return varName + " = " + value.ToString();
        }
    }
}
