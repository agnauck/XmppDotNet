using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Stream.Features
{
    [XmppTag(Name = "register", Namespace = Namespaces.FeatureIqRegister)]
    public class Register : XmppXElement
    {
        public Register() : base(Namespaces.FeatureIqRegister, "register")
        {
        }
    }
}
