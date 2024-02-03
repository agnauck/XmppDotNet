using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Sasl;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "mechanism", Namespace = Namespaces.Sasl2)]
    public class Mechanism : Sasl.Mechanism
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bind2.Mechanism"/> class.
        /// </summary>
        public Mechanism()
            : base(Namespaces.Sasl2)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Bind2.Mechanism"/> class.
        /// </summary>
        /// <param name="mechanism">The mechanism.</param>
        public Mechanism(SaslMechanism mechanism)
            : this()
        {
            SaslMechanism = mechanism;
        }
    }
}
