using Lab_c_sharp.Domain;
using Lab_c_sharp.Domain.Statements;
using Lab_c_sharp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Controller
{
    class Controller
    {
        IRepository repo;

        public Controller(IRepository repo)
        {
            this.repo = repo;
        }

        public void OneStep(PrgState prg)
        {
            if (prg.ExeStack.IsEmpty())
                return;
            IStatement crtStmt = prg.ExeStack.Pop();
            crtStmt.execute(prg);
        }

        public string AllStep()
        {
            PrgState crtPrg = repo.getCrtPrg();
            string result = "";
            while (!crtPrg.ExeStack.IsEmpty())
            {
                OneStep(crtPrg);
                result += crtPrg.ToString();
                repo.logPrgStateExec(crtPrg);
            }
            result += "\n" + crtPrg.OutTable.ToString();
            return result;
        }
    }
}
