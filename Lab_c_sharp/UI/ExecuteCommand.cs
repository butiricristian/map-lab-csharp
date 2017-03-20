using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.UI
{
    class ExecuteCommand : Command
    {
        private Controller.Controller ctrl;

        public ExecuteCommand(string key, string desc, Controller.Controller ctrl) : base(key, desc)
        {
            this.ctrl = ctrl;
        }

        public override void execute()
        {
            try
            {
                string res = ctrl.AllStep();
                Console.WriteLine(res);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
