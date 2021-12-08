using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Blocking
{
    [XmppTag(Name = "block", Namespace = Namespaces.Blocking)]
    public class Block : BlockBase
    {
        public Block()
            : base("block")
        {
        }
    }
}
