using Lab_c_sharp.Domain.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class ReadFile : IStatement
    {
        Expression fileVar;
        string varName;

        public ReadFile(Expression fileVar, string varName)
        {
            this.fileVar = fileVar;
            this.varName = varName;
        }

        public PrgState execute(PrgState crtPrg)
        {
            int fileDescr = fileVar.evaluate(crtPrg.SymTable);
            int value = Int32.Parse(crtPrg.FileTable[fileDescr].Value.ReadLine());
            crtPrg.SymTable.Put(varName, value);
            return null;
        }

        public override string ToString()
        {
            return "readFile(" + fileVar.ToString() + "," + varName + ")";
        }
    }
}
