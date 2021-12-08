using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.AdvancedMessageProcessing
{
    [XmppTag(Name = "invalid-rules", Namespace = Namespaces.AMP)]
    public class InvalidRules : XmppXElementWithRules
    {
        public InvalidRules() : base(Namespaces.AMP, "invalid-rules")
        {
        }
    }
}
