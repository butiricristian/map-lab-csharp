using Lab_c_sharp.Domain;
using Lab_c_sharp.Domain.ADT;
using Lab_c_sharp.Domain.Statements;
using Lab_c_sharp.Domain.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_c_sharp.UI;
using System.IO;

namespace Lab_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            IStatement prg1 = new PrintStatement(new ConstExpression(2));
            PrgState state1 = new PrgState(new MyStack<IStatement>(new Stack<IStatement>()),
                new MyDictionary<string, int>(new Dictionary<string, int>()),
                new MyList<String>(new List<string>()),
                new MyFileTable<KeyValuePair<string, StreamReader>>(new Dictionary<int, KeyValuePair<string, StreamReader>>()),
                prg1);
            Repository.Repository repo1 = new Repository.Repository(state1, "log1.txt");
            Controller.Controller ctrl1 = new Controller.Controller(repo1);


            IStatement prg2 = new CompStatement(new OpenRFile("f", "file.txt"),
                new CompStatement(new ReadFile(new VarExpression("f"), "c"),
                    new CompStatement(new PrintStatement(new VarExpression("c")),
                        new CompStatement(new IfStatement(new VarExpression("c"),
                            new CompStatement(new ReadFile(new VarExpression("f"), "c"), new PrintStatement(new VarExpression("c"))),
                            new PrintStatement(new ConstExpression(0))
                            ),
                            new CloseRFile("f")
                        )
                    )
                ));
            PrgState state2 = new PrgState(new MyStack<IStatement>(new Stack<IStatement>()),
                new MyDictionary<string, int>(new Dictionary<string, int>()),
                new MyList<String>(new List<string>()),
                new MyFileTable<KeyValuePair<string, StreamReader>>(new Dictionary<int, KeyValuePair<string, StreamReader>>()),
                prg2);
            Repository.Repository repo2 = new Repository.Repository(state2, "log2.txt");
            Controller.Controller ctrl2 = new Controller.Controller(repo2);





            ui.AddCommand(new ExecuteCommand("1", "Press 1 to execute program 1", ctrl1));
            ui.AddCommand(new ExecuteCommand("2", "Press 2 to execute program 2", ctrl2));
            ui.AddCommand(new ExitCommand("0", "Press 0 to exit"));
            ui.Show();
        }
    }
}
