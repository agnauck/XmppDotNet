using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.SecurityLabels
{
    [XmppTag(Name = "esssecuritylabel", Namespace = Namespaces.SecurityLabelEss)]
    public class EssSecurityLabel : XmppXElement
    {
        public EssSecurityLabel()
            : base(Namespaces.SecurityLabelEss, "esssecuritylabel")
        {
        }
    }
}
