using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.UI
{
    abstract class Command
    {
        public string Key { get; set; }
        public string Description { get; set; }

        public Command(string key, string desc)
        {
            Key = key;
            Description = desc;
        }

        public abstract void execute();
    }
}
