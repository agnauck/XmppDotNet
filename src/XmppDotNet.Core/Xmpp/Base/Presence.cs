using XmppDotNet.Xmpp.Delay;
using System;
using XmppDotNet.Xmpp.Muc;

namespace XmppDotNet.Xmpp.Base
{
    /// <summary>
    /// Presence Base class
    /// </summary>
    public abstract class Presence : XmppXElementWithAddressAndId
    {
        #region << Constructors >>
        internal Presence(string ns) : base(ns, Tag.Presence)
        {
        }
        #endregion

        #region << Properties
        /// <summary>
        /// The OPTIONAL status contains a natural-language description of availability status. 
        /// It is normally used in conjunction with the show element to provide a detailed description of an availability state 
        /// (e.g., "In a meeting").
        /// </summary>
        public string Status
        {
            get { return GetTag(Tag.Status); }
            set { SetTag(Tag.Status, value); }
        }

        /// <summary>
        /// The type of a presence stanza is OPTIONAL. 
        /// A presence stanza that does not possess a type attribute is used to signal to the server that the sender is online and available 
        /// for communication. If included, the type attribute specifies a lack of availability, a request to manage a subscription 
        /// to another entity's presence, a request for another entity's current presence, or an error related to a previously-sent 
        /// presence stanza.
        /// </summary>
        public PresenceType Type
        {
            get
            {
                return GetAttributeEnum<PresenceType>("type");
            }
            set
            {
                // dont add type="available"
                if (value == PresenceType.Available)
                    RemoveAttribute("type");
                else
                    SetAttribute("type", value.ToString().ToLower());
            }
        }

        /// <summary>
        /// The OPTIONAL show element contains non-human-readable XML character data that specifies the particular availability
        /// status of an entity or specific resource.
        /// </summary>
        public Show Show
        {
            get { return GetTagEnumUsingNameAttrib<Show>(Tag.Show); }
            set
            {
                if (value != Show.None)
                    SetTag(Tag.Show, value.GetName());
                else
                    RemoveTag(Tag.Show);
            }
        }

        /// <summary>
        /// The priority level of the resource. The value MUST be an integer between -128 and +127. 
        /// If no priority is provided, a server SHOULD consider the priority to be zero.         
        /// </summary>
        /// <remarks>
        /// For information regarding the semantics of priority values in stanza routing 
        /// within instant messaging and presence applications, refer to Server Rules 
        /// for Handling XML StanzasServer Rules for Handling XML Stanzas.
        /// </remarks>
        public int Priority
        {
            get
            {
                if (HasTag("priority"))
                {
                    int priority = 0;
                    int.TryParse(GetTag("priority"), out priority);
                    return priority;
                }                
                
                return 0;                
            }
            set
            {
                Contract.Requires<ArgumentException>(value.IsInRange(-127, 127), "The value must be an integer between - 128 and + 127.");
                SetTag("priority", value.ToString());
            }
        }
        #endregion

        #region << Extension Properties >>
        /// <summary>
        /// Gets or sets the <see cref="Delay"/>.
        /// </summary>
        /// <value>The delay.</value>
        public Delay.Delay Delay
        {
            get => Element<Delay.Delay>();
            set => Replace(value);
        }

        /// <summary>
        /// Gets or sets the <see cref="XDelay"/>.
        /// </summary>
        /// <value>The X delay.</value>
        public XDelay XDelay
        {
            get => Element<XDelay>();
            set => Replace(value);
        }

        /// <summary>
        /// Gets or sets the <see cref="XmppDotNet.Xmpp.Vcard.Update.X"/> element for Vcard photo advertisements.
        /// </summary>
        /// <value>The <see cref="XmppDotNet.Xmpp.Vcard.Update.X"/>.</value>
        public Vcard.Update.X VcardUpdate
        {
            get { return Element<Vcard.Update.X>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the <see cref="XmppDotNet.Xmpp.Muc.User.X"/>.
        /// </summary>
        /// <value>The muc.</value>
        public Muc.X Muc
        {
            get => Element<Muc.X>();
            set => Replace(value);
        }

        /// <summary>
        /// Gets or sets the <see cref="XmppDotNet.Xmpp.Muc.User.X"/>.
        /// </summary>
        /// <value>The muc user.</value>
        public Muc.User.X MucUser
        {
            get => Element<Muc.User.X>();
            set => Replace(value);
        }

        /// <summary>
        /// Gets or sets the <see cref="XmppDotNet.Xmpp.Capabilities.Caps"/>.
        /// </summary>
        /// <value>The caps.</value>
        public Capabilities.Caps Caps
        {
            get => Element<Capabilities.Caps>();
            set => Replace(value);
        }
        
        /// <summary>
        /// Gets or Sets the occupant Id (XEP-0421)
        /// </summary>
        public OccupantId OccupantId
        {
            get => Element<OccupantId>();
            set => Replace(value);
        }
        #endregion
    }
}
