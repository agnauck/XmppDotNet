using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub.Owner
{
    [XmppTag(Name = "purge", Namespace = Namespaces.PubsubOwner)]
    public class Purge : Xmpp.PubSub.Purge
    {
        public Purge() : base(Namespaces.PubsubOwner)
        {
        }
    }
}
