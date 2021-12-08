using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.AdvancedMessageProcessing
{
    [XmppTag(Name = "unsupported-actions", Namespace = Namespaces.AMP)]
    public class UnsupportedActions : XmppXElementWithRules
    {
        public UnsupportedActions() : base(Namespaces.AMP, "unsupported-actions")
        {
        }
    }
}
