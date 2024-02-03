using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "authenticate", Namespace = Namespaces.Sasl2)]
    public class Authenticate : XmppXElement
    {
        public Authenticate() : base(Namespaces.Sasl2, "authenticate")
        {
        }
        
        /// <summary>
        /// Gets or sets the sasl mechanism.
        /// </summary>
        /// <value>
        /// The sasl mechanism.
        /// </value>
        public SaslMechanism SaslMechanism
        {
            get { return Mechanism.GetSaslMechanism(GetAttribute("mechanism")); }
            set { SetAttribute("mechanism", Mechanism.GetSaslMechanismName(value)); }
        }
        
        /// <summary>
        /// The <see cref="InitialResponse"/> Element
        /// </summary>
        public InitialResponse InitialResponse
        {
            get { return Element<InitialResponse>(); }
            set { Replace(value); }
        }
        
        /// <summary>
        /// The <see cref="Bind2.Bind"/> Element
        /// </summary>
        public Bind2.Bind Bind
        {
            get { return Element<Bind2.Bind>(); }
            set { Replace(value); }
        }
    }
}
