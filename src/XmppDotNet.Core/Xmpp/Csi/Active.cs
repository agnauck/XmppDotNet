using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Csi
{
    [XmppTag(Name = "active", Namespace = Namespaces.ClientStateIndication)]
    public class Active : XmppXElement
    {
        public Active() : base(Namespaces.ClientStateIndication, "active")
        {
        }
    }
}