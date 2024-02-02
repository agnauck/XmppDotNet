using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Sasl2
{
    /// <summary>
    /// Sasl2 success object.
    /// </summary>
    [XmppTag(Name = "success", Namespace = Namespaces.Sasl2)]
    public class Success : XmppXElement
    {
        public Success() : base(Namespaces.Sasl2, "success")
        {
        }

        public Jid AuthorizationIdentifier
        {
            get { return GetTagJid("authorization-identifier"); }
            set { SetTag("authorization-identifier", value); }
        }
    }
}
