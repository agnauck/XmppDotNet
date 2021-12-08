using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Stream.Features
{
    [XmppTag(Name = "bidi", Namespace = Namespaces.FeatureBidi)]
    public class Bidi : XmppXElement
    {
        public Bidi() : base(Namespaces.FeatureBidi, "bidi")
        {
        }
    }
}
