using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.AdvancedMessageProcessing
{
    [XmppTag(Name = "unsupported-conditions", Namespace = Namespaces.AMP)]
    public class UnsupportedConditions : XmppXElementWithRules
    {
        public UnsupportedConditions() : base(Namespaces.AMP, "unsupported-conditions")
        {
        }
    }
}
