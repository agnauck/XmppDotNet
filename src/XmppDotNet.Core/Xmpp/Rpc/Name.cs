using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "name", Namespace = Namespaces.IqRpc)]
    internal class Name : XmppXElement
    {
        public Name()
            : base(Namespaces.IqRpc, "name")
        {
        }
    }
}
