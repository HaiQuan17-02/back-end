using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class SoAmException : Exception
    {
        public SoAmException()
        {
        }

        public SoAmException(string? message) : base(message)
        {
        }

        public SoAmException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
