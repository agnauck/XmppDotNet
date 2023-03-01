using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "forwarded", Namespace = Namespaces.Forward)]
    public class Forwarded : XmppXElement
    {
        public Forwarded() : base(Namespaces.Forward, "forwarded") { }

        public Message Message
        {
            get { return Element<Message>(); }
            set { Replace(value); }
        }
    }
}
