using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.UI
{
    class UserInterface
    {
        Dictionary<string, Command> Commands;

        public UserInterface()
        {
            Commands = new Dictionary<string, Command>();
        }

        public void AddCommand(Command c)
        {
            Commands.Add(c.Key, c);
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu: ");
            foreach(Command c in Commands.Values)
            {
                Console.WriteLine("\t" + c.Description);
            }
        }

        public void Show()
        {
            string option;
            while (true)
            { 
                PrintMenu();
                Console.Write("Choose one of the above: ");
                option = Console.ReadLine();
                Command cmd = null;
                try
                {
                    cmd = Commands[option];
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid option!");
                    continue;
                }
                cmd.execute();
            }
        }
    }
}
