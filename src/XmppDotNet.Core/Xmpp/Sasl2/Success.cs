using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Bind2;

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
        
        /// <summary>
        /// The <see cref="Bound"/> Element
        /// </summary>
        public Bound Bound
        {
            get { return Element<Bound>(); }
            set { Replace(value); }
        }
    }
}
