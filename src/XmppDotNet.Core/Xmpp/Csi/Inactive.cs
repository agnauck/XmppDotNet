using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Csi
{
    [XmppTag(Name = "inactive", Namespace = Namespaces.ClientStateIndication)]
    public class Inactive : XmppXElement
    {
        public Inactive() : base(Namespaces.ClientStateIndication, "inactive")
        {
        }
    }
}