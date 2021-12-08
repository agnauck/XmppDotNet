using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.IBB
{
    public enum StanzaType
    {
        [Name("iq")]
        Iq = -1,

        [Name("message")]
        Message,
    }
}
