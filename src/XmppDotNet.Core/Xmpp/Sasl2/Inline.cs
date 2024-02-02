using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "inline", Namespace = Namespaces.Sasl2)]
    public class Inline : XmppXElement
    {
        public Inline()
            : base(Namespaces.Sasl2, "inline")
        {
        }
    }
}
