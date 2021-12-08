using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "to", Namespace = Namespaces.Archiving)]
    public class To : MessageItem
    {
        public To() : base("to")
        {
        }
    }
}
