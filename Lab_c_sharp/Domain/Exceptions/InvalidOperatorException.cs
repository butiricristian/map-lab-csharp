using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Exceptions
{
    class InvalidOperatorException : Exception
    {
        public InvalidOperatorException(string message) : base(message)
        {
        }
    }
}
