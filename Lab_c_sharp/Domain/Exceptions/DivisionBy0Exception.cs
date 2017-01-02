using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Exceptions
{
    class DivisionBy0Exception : Exception
    {
        public DivisionBy0Exception(string msg) : base(msg)
        {
        }
    }
}
