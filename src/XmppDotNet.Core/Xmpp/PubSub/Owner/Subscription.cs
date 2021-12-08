using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub.Owner
{
    [XmppTag(Name = "subscription", Namespace = Namespaces.PubsubOwner)]
    public class Subscription : Base.Subscription
    {
        public Subscription() : base(Namespaces.PubsubOwner)
        {
        }
    }
}
