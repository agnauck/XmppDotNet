using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.SecurityLabels
{
    [XmppTag(Name = "label", Namespace = Namespaces.SecurityLabel)]
    public class Label : XmppXElement
    {
        public Label() : base(Namespaces.SecurityLabel, "label")
        {
        }

        internal Label(string tagname)
            : base(Namespaces.SecurityLabel, tagname)
        {
        }

        public EssSecurityLabel EssSecurityLabel
        {
            get { return Element<EssSecurityLabel>(); }
            set { Replace(value); }
        }
    }
}
