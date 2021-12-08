using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub.Event
{
    [XmppTag(Name = "configuration", Namespace = Namespaces.PubsubEvent)]
    public class Configuration : Configure
    {
        public Configuration() : base(Namespaces.PubsubEvent, "configuration")
        {
        }
    }
}
