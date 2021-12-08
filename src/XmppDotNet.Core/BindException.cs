using XmppDotNet.Xml;

namespace XmppDotNet
{
    public class BindException : XmppException
    {
        public BindException(XmppXElement stanza) : base(stanza) { }
    }
}
