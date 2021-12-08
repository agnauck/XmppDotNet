using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Bytestreams
{
    public enum Mode
    {
        None = -1,

        [Name("tcp")]
        Tcp,
        
        [Name("udp")]
        Udp
    }
}
