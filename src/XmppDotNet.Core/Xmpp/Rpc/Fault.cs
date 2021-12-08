using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "fault", Namespace = Namespaces.IqRpc)]
    internal class Fault : XmppXElement
    {
        public Fault()
            : base(Namespaces.IqRpc, "fault")
        {
        }
    }
}
