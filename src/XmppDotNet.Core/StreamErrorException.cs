using XmppDotNet.Xml;

namespace XmppDotNet
{
    public class StreamErrorException : XmppException
    {
        public StreamErrorException(XmppXElement stanza) : base(stanza) { }
    }
}
