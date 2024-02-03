using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Sasl;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "authentication", Namespace = Namespaces.Sasl2)]
    public class Authentication : Mechanisms
    {
        public Authentication()
            : base(Namespaces.Sasl2, "authentication")
        {			
        }
        
        /// <summary>
        /// The <see cref="Inline"/> Element
        /// </summary>
        public Inline Inline
        {
            get { return Element<Inline>(); }
            set { Replace(value); }
        }
    }
}