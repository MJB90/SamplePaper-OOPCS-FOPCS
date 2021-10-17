using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaper.OOPCS
{
    class InvalidTimeZoneException:Exception
    {
        public InvalidTimeZoneException() : base()
        {

        }
        public InvalidTimeZoneException(string message) : base(message)
        {

        }
    }
}
