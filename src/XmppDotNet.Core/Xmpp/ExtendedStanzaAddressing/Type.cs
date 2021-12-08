using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.ExtendedStanzaAddressing
{
    public enum Type
    {
        [Name("bcc")]
        Bcc,

        [Name("cc")]
        Cc,

        [Name("noreply")]
        Noreply,

        [Name("replyroom")]
        Replyroom,

        [Name("replyto")]
        Replyto,

        [Name("to")]
        To
    }
}
