using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "enable", Namespace = Namespaces.MessageCarbons)]
    public class Enable : CarbonBase
    {
        public Enable() : base("enable") { }
    }
}
