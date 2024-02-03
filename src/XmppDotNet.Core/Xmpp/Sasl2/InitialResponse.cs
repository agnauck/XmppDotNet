using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "initial-response", Namespace = Namespaces.Sasl2)]
    public class InitialResponse : XmppXElementWithBased64Value
    {
        public InitialResponse() : base(Namespaces.Sasl2, "initial-response")
        {
        }
    }
}
