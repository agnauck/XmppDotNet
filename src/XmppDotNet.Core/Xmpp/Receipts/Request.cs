using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Receipts
{
    [XmppTag(Name = "request", Namespace = Namespaces.MessageReceipts)]
    public class Request : XmppXElement
    {
        public Request()
            : base(Namespaces.MessageReceipts, "request")
        {
        }
    }
}
