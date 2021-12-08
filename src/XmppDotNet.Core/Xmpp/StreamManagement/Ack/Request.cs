using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.StreamManagement.Ack
{
    [XmppTag(Name = "r", Namespace = Namespaces.FeatureStreamManagement)]
    public class Request : XmppXElement
    {
        public Request() : base(Namespaces.FeatureStreamManagement, "r")
        {
        }
    }
}
