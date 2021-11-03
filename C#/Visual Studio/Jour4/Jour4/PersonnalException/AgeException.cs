using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jour4.PersonnalException
{
    class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {

        }
    }
}
