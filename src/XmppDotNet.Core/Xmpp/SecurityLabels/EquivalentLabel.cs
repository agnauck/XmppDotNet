using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.SecurityLabels
{
    [XmppTag(Name = "equivalentlabel", Namespace = Namespaces.SecurityLabel)]
    public class EquivalentLabel : Label
    {
        public EquivalentLabel()
            : base("equivalentlabel")
        {
        }
    }
}
