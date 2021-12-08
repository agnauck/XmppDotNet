using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "member", Namespace = Namespaces.IqRpc)]
    internal class Member : XmppXElement
    {
        public Member()
            : base(Namespaces.IqRpc, "member")
        {
        }
    }
}
