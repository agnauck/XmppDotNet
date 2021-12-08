using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "next", Namespace = Namespaces.Archiving)]
    public class Next : Link
    {
        public Next() : base("next")
        {
        }
    }
}
