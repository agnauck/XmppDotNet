using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Google.Mobile
{
    [XmppTag(Name = "gcm", Namespace = Namespaces.GoogleMobileData)]
    public class Gcm : XmppXElement
    {
        public Gcm() : base(Namespaces.GoogleMobileData, "gcm")
        {
        }
    }
}
