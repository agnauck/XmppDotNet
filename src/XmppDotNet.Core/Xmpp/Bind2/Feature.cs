using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Bind2
{
    [XmppTag(Name = "feature", Namespace = Namespaces.Bind2)]
    public class Feature : Disco.Feature
    {
        public Feature() : base(Namespaces.Bind2, "feature")
        {
        }
    }
}