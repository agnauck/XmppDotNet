using XmppDotNet.Xml;

namespace XmppDotNet
{
    public class AuthenticationException : XmppException
    {
        public AuthenticationException(XmppXElement stanza) : base(stanza) { }
    }
}
