using System;

namespace Exercice01.PersonnalException
{
    class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
