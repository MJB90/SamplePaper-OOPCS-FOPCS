using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class InvalidSecondException : Exception
    {
        public InvalidSecondException() : base()
        {

        }
        public InvalidSecondException(string message) : base(message)
        {

        }
    }
}
