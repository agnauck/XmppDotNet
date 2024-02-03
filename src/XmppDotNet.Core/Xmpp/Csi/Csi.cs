using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Csi
{
    [XmppTag(Name = "csi", Namespace = Namespaces.ClientStateIndication)]
    public class Csi : XmppXElement
    {
        public Csi() : base(Namespaces.ClientStateIndication, "csi")
        {
        }
    }
}