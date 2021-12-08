using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.FeatureNegotiation
{
    [XmppTag(Name = "feature", Namespace = Namespaces.FeatureNeg)]
    public class Feature : XmppXElementWithXData
    {
        public Feature() : base(Namespaces.FeatureNeg, "feature")
        {
        }
    }
}
