using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    [XmppTag(Name = "private", Namespace = Namespaces.MessageCarbons)]
    public class Private : CarbonBase
    {
        public Private() : base("private") { }
    }
}
