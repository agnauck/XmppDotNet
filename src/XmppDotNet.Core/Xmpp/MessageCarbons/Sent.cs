using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "sent", Namespace = Namespaces.MessageCarbons)]
    public class Sent : ForwardContainer
    {
        public Sent() : base("sent") { }
    }
}
