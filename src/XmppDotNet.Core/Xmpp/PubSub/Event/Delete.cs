using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub.Event
{
    [XmppTag(Name = "delete", Namespace = Namespaces.PubsubEvent)]
    public class Delete : Xmpp.PubSub.Delete
    {
        public Delete() : base(Namespaces.PubsubEvent)
        {
        }
    }
}
