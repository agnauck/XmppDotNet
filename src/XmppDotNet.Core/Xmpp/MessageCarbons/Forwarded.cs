using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "forwarded", Namespace = Namespaces.Forward)]
    public class Forwarded : XmppXElement
    {
        public Forwarded() : base(Namespaces.Forward, "forwarded") { }
    }
}
