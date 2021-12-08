using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.StreamManagement
{
    [XmppTag(Name = "resumed", Namespace = Namespaces.FeatureStreamManagement)]
    public class Resumed : Resume
    {
        public Resumed() : base("resumed")
        {
        }
    }
}
