using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "value", Namespace = Namespaces.IqRpc)]
    internal class Value : XmppXElement
    {
        public Value() : base(Namespaces.IqRpc, "value")
        {
        }
    }
}
