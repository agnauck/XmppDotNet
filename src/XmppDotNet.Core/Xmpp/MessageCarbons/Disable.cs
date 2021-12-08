using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageCarbons
{
     [XmppTag(Name = "disable", Namespace = Namespaces.MessageCarbons)]
    public class Disable : CarbonBase
    {
        public Disable() : base("disable") { }
    }
}
