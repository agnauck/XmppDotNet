using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "array", Namespace = Namespaces.IqRpc)]
    internal class Array : XmppXElement
    {
        public Array()
            : base(Namespaces.IqRpc, "array")
        {
        }
    }
}
