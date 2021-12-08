using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "param", Namespace = Namespaces.IqRpc)]
    internal class Param : XmppXElement
    {
        public Param()
            : base(Namespaces.IqRpc, "param")
        {
        }
    }
}
