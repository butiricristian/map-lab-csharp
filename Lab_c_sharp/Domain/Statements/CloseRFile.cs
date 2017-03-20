using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class CloseRFile : IStatement
    {
        string fileVar;

        public CloseRFile(string fileVar)
        {
            this.fileVar = fileVar;
        }

        public PrgState execute(PrgState crtPrg)
        {
            int fileDescr = crtPrg.SymTable[fileVar];
            crtPrg.FileTable[fileDescr].Value.Close();
            crtPrg.FileTable.Remove(fileDescr);
            return null;
        }

        public override string ToString()
        {
            return "closeRFile(" + fileVar + ")";
        }
    }
}
