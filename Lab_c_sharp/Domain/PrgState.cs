using Lab_c_sharp.Domain.ADT;
using Lab_c_sharp.Domain.Statements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain
{
    class PrgState
    {
        //MyIStack<IStatement> exeStack;
        //MyIDictionary<string, int> symTable;
        //MyIList<string> outTable;
        //IStatement prg;

        public MyIStack<IStatement> ExeStack { get; set; }
        public MyIDictionary<string, int> SymTable { get; set; }
        public MyIList<string> OutTable { get; set; }
        public MyIFileTable<KeyValuePair<string, StreamReader>> FileTable { get; set; }
        public IStatement Prg { get; set; }

        public PrgState(MyIStack<IStatement> exeStack, 
            MyIDictionary<string, int> symTable, 
            MyIList<string> outTable,
            MyIFileTable<KeyValuePair<string, StreamReader>> fileTable,
            IStatement prg)
        {
            ExeStack = exeStack;
            SymTable = symTable;
            OutTable = outTable;
            FileTable = fileTable;
            Prg = prg;
            ExeStack.Add(prg);
        }

        public override string ToString()
        {
            return "Exe Stack: \n" + ExeStack.ToString() + "\nSymTable: \n" + SymTable.ToString() +
                "\nOut: \n" + OutTable.ToString() + "\nFileTable: \n" + FileTable.ToString() + "\n\n";
        }
    }
}
