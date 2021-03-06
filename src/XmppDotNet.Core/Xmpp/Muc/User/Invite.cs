using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.Muc.User
{
    /// <summary>
    /// Invite
    /// </summary>
    [XmppTag(Name = "invite", Namespace = Namespaces.MucUser)]
    public class Invite : XmppXElementWithAddress
    {
        /*
          <message to='darkcave@chat.shakespeare.lit'>
              <x xmlns='http://jabber.org/protocol/muc#user'>
                <invite to='hecate@shakespeare.lit'>
                  <password>cauldronburn</password>
                </invite>
              </x>
          </message>
         
          <invite to='wiccarocks@shakespeare.lit/laptop'>
            <reason>This coven needs both wiccarocks and hag66.</reason>
            <continue thread='e0ffe42b28561960c6b12b944a092794b9683a38'/>
          </invite>

          
          <xs:element name='invite'>
            <xs:complexType>
              <xs:sequence>
                <xs:element ref='reason' minOccurs='0'/>
              </xs:sequence>
              <xs:attribute name='from' type='xs:string' use='optional'/>
              <xs:attribute name='to' type='xs:string' use='optional'/>
            </xs:complexType>
          </xs:element>
        */

        #region << Constructors >>
        /// <summary>
        /// Initializes a new instance of the <see cref="Invite"/> class.
        /// </summary>
        public Invite()
            : base(Namespaces.MucUser, "invite")
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Invite"/> class.
        /// </summary>
        /// <param name="to">To.</param>
        public Invite(Jid to)
            : this()
        {
            To = to;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Invite"/> class.
        /// </summary>
        /// <param name="to">To.</param>
        /// <param name="from">From.</param>
        public Invite(Jid to, Jid from)
            : this(to)
        {
            From = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite"/> class.
        /// </summary>
        /// <param name="to">To.</param>
        /// <param name="reason">The reason.</param>
        public Invite(Jid to, string reason)
            : this(to)
        {
            Reason = reason;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Invite"/> class.
        /// </summary>
        /// <param name="to">To.</param>
        /// <param name="from">From.</param>
        /// <param name="reason">The reason.</param>
        public Invite(Jid to, Jid from, string reason)
            : this(to, from)
        {
            Reason = reason;
        }
        #endregion

        /// <summary>
        /// Gets or sets the continue object.
        /// </summary>
        /// <value>The continue.</value>
        public Continue Continue
        {
            get { return Element<Continue>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the reason.
        /// </summary>
        /// <value>The reason.</value>
        public string Reason
        {
            set { SetTag("reason", value); }
            get { return GetTag("reason"); }
        }
    }
}
