using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "previous", Namespace = Namespaces.Archiving)]
    public class Previous : Link
    {
        public Previous() : base("previous")
        {
        }
    }
}
