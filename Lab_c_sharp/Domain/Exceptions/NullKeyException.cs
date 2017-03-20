using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Exceptions
{
    class NullKeyException : Exception
    {
        public NullKeyException(string message) : base(message) { }
    }
}
