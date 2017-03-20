using Lab_c_sharp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Repository
{
    interface IRepository
    {
        PrgState getCrtPrg();
        void logPrgStateExec(PrgState prg);
    }
}
