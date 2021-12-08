using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Blocking
{
    [XmppTag(Name = "unblock", Namespace = Namespaces.Blocking)]
    public class Unblock : BlockBase
    {
        public Unblock()
            : base("unblock")
        {
        }
    }
}
