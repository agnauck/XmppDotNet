using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "params", Namespace = Namespaces.IqRpc)]
    internal class Params : XmppXElement
    {
        public Params() : base(Namespaces.IqRpc, "params")
        {
        }
    }
}
