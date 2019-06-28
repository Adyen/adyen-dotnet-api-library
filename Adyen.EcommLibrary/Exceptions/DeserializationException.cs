using System;
using System.Collections.Generic;
using System.Text;

namespace Adyen.EcommLibrary.Exceptions
{
    public class DeserializationException : Exception
    {
        public DeserializationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
