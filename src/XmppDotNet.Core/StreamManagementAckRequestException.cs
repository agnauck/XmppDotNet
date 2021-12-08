using XmppDotNet.Xml;

namespace XmppDotNet
{
    public class StreamManagementAckRequestException : StreamManagementException
    {
        public StreamManagementAckRequestException(XmppXElement stanza, string message) : base(stanza, message) { }
    }   
}
