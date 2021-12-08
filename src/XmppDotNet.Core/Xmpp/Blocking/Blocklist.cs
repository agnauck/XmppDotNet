using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Blocking
{
    [XmppTag(Name = "blocklist", Namespace = Namespaces.Blocking)]
    public class Blocklist : BlockBase
    {
        public Blocklist() : base("blocklist")
        {
        }
    }
}
