using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "data", Namespace = Namespaces.IqRpc)]
    internal class Data : XmppXElement
    {
        public Data()
            : base(Namespaces.IqRpc, "data")
        {
        }
    }
}
