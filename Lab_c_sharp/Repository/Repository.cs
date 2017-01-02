using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_c_sharp.Domain;
using System.IO;

namespace Lab_c_sharp.Repository
{
    class Repository : IRepository
    {
        List<PrgState> repo;
        string path;

        public Repository(PrgState prg, string path)
        {
            repo = new List<PrgState>();
            repo.Add(prg);
            this.path = path;
        }

        public PrgState getCrtPrg()
        {
            return repo[0];
        }

        public void logPrgStateExec(PrgState prg)
        {
            using (StreamWriter log = new StreamWriter(path))
            {
                log.WriteLine(prg.ToString());
            }
        }
    }
}
