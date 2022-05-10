using System;

namespace BusinessLogic
{
    public class DomainException : Exception
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}