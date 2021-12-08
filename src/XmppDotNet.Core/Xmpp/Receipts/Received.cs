using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.Receipts
{
    [XmppTag(Name = "received", Namespace = Namespaces.MessageReceipts)]
    public class Received : XmppXElementWithIdAttribute
    {
        public Received()
            : base(Namespaces.MessageReceipts, "received")
        {
        }
    }
}
