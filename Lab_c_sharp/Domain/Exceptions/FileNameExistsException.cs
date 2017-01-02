using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_c_sharp.Domain.Exceptions
{
    class FileNameExistsException : Exception
    {
        public FileNameExistsException(string message) : base(message) { }
    }
}
