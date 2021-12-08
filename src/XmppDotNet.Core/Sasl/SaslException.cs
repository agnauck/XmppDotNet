using System;

namespace XmppDotNet.Sasl
{
    public class SaslException : Exception
    {
        public SaslException(string message) : base(message)
        {
        }
    }
}
