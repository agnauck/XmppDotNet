using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Stream.Features
{
    [XmppTag(Name = "auth", Namespace = Namespaces.FeatureAuth)]
    public class Auth : XmppXElement
    {
        public Auth()
            : base(Namespaces.FeatureAuth, "auth")
        {
        }
    }
}
