using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub.Event
{
    [XmppTag(Name = "purge", Namespace = Namespaces.PubsubEvent)]
    public class Purge : Xmpp.PubSub.Purge
    {
        public Purge() : base(Namespaces.PubsubEvent)
        {
        }
    }
}
