using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "from", Namespace = Namespaces.Archiving)]
    public class From : MessageItem
    {
        public From() : base("from")
        {
        }
    }
}
