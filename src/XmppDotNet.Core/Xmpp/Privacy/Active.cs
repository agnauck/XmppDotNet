using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Privacy
{
    [XmppTag(Name = "active", Namespace = Namespaces.IqPrivacy)]
    public class Active : Base.XmppXElementWithNameAttribute
    {
        public Active() : base(Namespaces.IqPrivacy, "active")
        {
        }
    }
}
