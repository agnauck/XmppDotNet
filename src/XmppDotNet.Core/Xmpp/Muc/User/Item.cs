using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Muc.User
{
    /*
    <xs:element name='item'>
        <xs:complexType>
          <xs:sequence>
            <xs:element ref='actor' minOccurs='0'/>
            <xs:element ref='reason' minOccurs='0'/>
            <xs:element ref='continue' minOccurs='0'/>
          </xs:sequence>
          
          <xs:attribute name='affiliation' use='optional'>
            <xs:simpleType>
              <xs:restriction base='xs:NCName'>
                <xs:enumeration value='admin'/>
                <xs:enumeration value='member'/>
                <xs:enumeration value='none'/>
                <xs:enumeration value='outcast'/>
                <xs:enumeration value='owner'/>
              </xs:restriction>
            </xs:simpleType>
          </xs:attribute>
          
          <xs:attribute name='jid' type='xs:string' use='optional'/>
          <xs:attribute name='nick' type='xs:string' use='optional'/>
          
          <xs:attribute name='role' use='optional'>
            <xs:simpleType>
              <xs:restriction base='xs:NCName'>
                <xs:enumeration value='moderator'/>
                <xs:enumeration value='none'/>
                <xs:enumeration value='participant'/>
                <xs:enumeration value='visitor'/>
              </xs:restriction>
            </xs:simpleType>
          </xs:attribute>
        </xs:complexType>
    </xs:element>
    */

    /// <summary>
    /// 
    /// </summary>
    [XmppTag(Name = Tag.Item, Namespace = Namespaces.MucUser)]
    public class Item : Muc.Item
    {
        #region << Constructors >>
        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
            : base(Namespaces.MucUser)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="affiliation">The affiliation.</param>
        public Item(Affiliation affiliation)
            : this()
        {
            Affiliation = affiliation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="role">The role.</param>
        public Item(Role role)
            : this()
        {
            Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="affiliation">The affiliation.</param>
        /// <param name="role">The role.</param>
        public Item(Affiliation affiliation, Role role)
            : this(affiliation)
        {
            Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="affiliation">The affiliation.</param>
        /// <param name="role">The role.</param>
        /// <param name="jid">The jid.</param>
        public Item(Affiliation affiliation, Role role, Jid jid)
            : this(affiliation, role)
        {
            Jid = jid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// <param name="affiliation">The affiliation.</param>
        /// <param name="role">The role.</param>
        /// <param name="jid">The jid.</param>
        /// <param name="nick">The nick.</param>
        public Item(Affiliation affiliation, Role role, Jid jid, string nick)
            : this(affiliation, role, jid)
        {
            Nickname = nick;
        }
        #endregion

        /// <summary>
        /// Gets or sets the <see cref="Continue"/>.
        /// </summary>
        /// <value>The continue.</value>
        public Continue Continue
        {
            get { return Element<Continue>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the <see cref="Actor"/>.
        /// </summary>
        /// <value>The actor.</value>
        public Actor Actor
        {
            get { return Element<Actor>(); }
            set { Replace(value); }
        }
    }
}
