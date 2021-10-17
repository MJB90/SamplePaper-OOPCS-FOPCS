using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class InvalidMinuteException : Exception
    {
        public InvalidMinuteException() : base()
        {

        }
        public InvalidMinuteException(string message) : base(message)
        {

        }

    }
}
