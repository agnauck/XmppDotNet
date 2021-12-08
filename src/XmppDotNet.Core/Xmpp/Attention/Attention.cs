using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Attention
{
    /// <summary>
    /// XEP-0224 Attention
    /// </summary>
    [XmppTag(Name = "attention", Namespace = Namespaces.Attention)]
    public class Attention : XmppXElement
    {
        public Attention()
            : base(Namespaces.Attention, "attention")
        {
        }
    }
}
