using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Exceptions
{
    public class DateNotAfterDate : Exception
    {
        public DateNotAfterDate()
        {
            
        }
        public DateNotAfterDate(string message):base(message)
        {
            
        }
    }
}
