using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class CompStatement : IStatement
    {
        IStatement prg1, prg2;

        public CompStatement(IStatement prg1, IStatement prg2)
        {
            this.prg1 = prg1;
            this.prg2 = prg2;
        }

        public PrgState execute(PrgState crtPrg)
        {
            crtPrg.ExeStack.Add(prg2);
            crtPrg.ExeStack.Add(prg1);
            return null;
        }

        public override string ToString()
        {
            return "(" +  prg1.ToString() + ",\n" + prg2.ToString() + ");";
        }
    }
}
