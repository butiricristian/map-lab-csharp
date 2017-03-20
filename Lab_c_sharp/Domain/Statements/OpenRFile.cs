using Lab_c_sharp.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Statements
{
    class OpenRFile : IStatement
    {
        string fileVar;
        string fileName;

        public OpenRFile(string fileVar, string fileName)
        {
            this.fileVar = fileVar;
            this.fileName = fileName;
        }

        public PrgState execute(PrgState crtPrg)
        {
            foreach(KeyValuePair<string, StreamReader> pair in crtPrg.FileTable.getValues())
            {
                if (pair.Key == fileName)
                    throw new FileNameExistsException("The file name already exists");
            }
            StreamReader sr = new StreamReader(fileName);
            int fileDescr = crtPrg.FileTable.Add(new KeyValuePair<string, StreamReader>(fileName, sr));
            crtPrg.SymTable.Put(fileVar, fileDescr);
            return null;
        }

        public override string ToString()
        {
            return "openRFile(" + fileVar + ", " + fileName + ")";
        }
    }
}
