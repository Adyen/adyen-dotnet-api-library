using System;

namespace Adyen.Security.Exceptions
{
    public class NexoCryptoException : Exception
    {
        public NexoCryptoException(string message) : base(message)
        {
        }
    }
}
