using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "received", Namespace = Namespaces.MessageCarbons)]
    public class Received : ForwardContainer
    {
        public Received() : base("received") { }
    }
}
