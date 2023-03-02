using System;
using XmppDotNet.Xmpp.Chatstates;
using XmppDotNet.Xmpp.Delay;
using XmppDotNet.Xmpp.ExtendedStanzaAddressing;
using XmppDotNet.Xmpp.LastMessageCorrection;
using XmppDotNet.Xmpp.MessageCarbons;
using XmppDotNet.Xmpp.Nickname;
using XmppDotNet.Xmpp.Receipts;
using XmppDotNet.Xmpp.RosterItemExchange;
using XmppDotNet.Xmpp.SecurityLabels;
using XmppDotNet.Xmpp.Shim;
using XmppDotNet.Xmpp.XData;
using XmppDotNet.Xmpp.XHtmlIM;
using Received = XmppDotNet.Xmpp.Receipts.Received;

namespace XmppDotNet.Xmpp.Base
{
    /// <summary>
    /// Abstract message base class
    /// </summary>
    public abstract class Message : XmppXElementWithAddressAndId
    {
        #region << Constructors >>
        internal Message(string ns) : base(ns, Tag.Message)       
        {           
        }        
        #endregion       

        #region << Properties >>
        /// <summary>
        /// The body of the message. This contains the message text.
        /// </summary>
        public string Body
        {
            set { SetTag(Tag.Body, value); }
            get { return GetTag(Tag.Body); }
        }

        /// <summary>
        /// subject of this message. Its like a subject in a email. The Subject is optional.
        /// </summary>
        public string Subject
        {
            set { SetTag(Tag.Subject, value); }
            get { return GetTag(Tag.Subject); }
        }

        /// <summary>
        /// messages and conversations could be threaded. You can compare this with threads in newsgroups or forums.
        /// Threads are optional.
        /// </summary>
        public string Thread
        {
            set { SetTag(Tag.Thread, value); }
            get { return GetTag(Tag.Thread); }
        }

        /// <summary>
        /// the message type (chat, groupchat, normal, headline or error).
        /// </summary>
        public MessageType Type
        {
            get { return GetAttributeEnum<MessageType>("type"); }
            set
            {
                if (value == MessageType.Normal)
                    RemoveAttribute("type");
                else
                    SetAttribute("type", value.ToString().ToLower());
            }
        }

        /// <summary>
        /// Gets a value indicating whether this message is a roster exchange.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is roster exchange; otherwise, <c>false</c>.
        /// </value>
        public bool IsRosterExchange
        {
            get { return Element<Exchange>() != null; }
        }

        /// <summary>
        /// Gets a value indicating whether this message is a received carbon message
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a received carbon message; otherwise, <c>false</c>.
        /// </value>
        public bool IsReceivedCarbon
        {
            get { return Element<MessageCarbons.Received>() != null; }
        }
        
        /// <summary>
        /// Gets a value indicating whether this message is a sent carbon message
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a sent carbon message; otherwise, <c>false</c>.
        /// </value>
        public bool IsSentCarbon
        {
            get { return Element<Sent>() != null; }
        }

        /// <summary>
        /// Gets a value indicating whether this message is a carbon message, either sent or received
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is a carbon message; otherwise, <c>false</c>.
        /// </value>
        public bool IsCarbon
        {
            get { return IsReceivedCarbon || IsSentCarbon; }
        }

        /// <summary>
        /// The sent Carbon object.
        /// </summary>
        /// <value>
        /// The sent carbon object, or null when this message contains no sent carbon.
        /// </value>
        public Sent SentCarbon
        {
            get { return Element<Sent>(); }
        }

        /// <summary>
        /// The received Carbon object.
        /// </summary>
        /// <value>
        /// The received carbon object, or null when this message contains no received carbon.
        /// </value>
        public MessageCarbons.Received ReceivedCarbon
        {
            get { return Element<MessageCarbons.Received>(); }
        }
        #endregion

        #region << Methods and Functions >>
        /// <summary>
        /// Create a new unique thread indendifier
        /// </summary>
        /// <returns></returns>
        public string CreateNewThread()
        {
            string guid = Guid.NewGuid().ToString().ToLower();
            Thread = guid;

            return guid;
        }

        #region << message delivery receipts (XEP-0184) >>
        /// <summary>
        /// Requests a message delivery receipt for this message (XEP-0184).
        /// </summary>
        public void RequestReceipt()
        {
            // receipts need an id
            if (Id == null)
                GenerateId();

            if (Element<Request>() == null)
                Add(new Request());
        }

        /// <summary>
        /// Generates the delivery receipt for this message (XEP-0184).
        /// </summary>
        /// <param name="id">The id of the message to acknowledge</param>
        public void DeliveryReceipt(string id)
        {
            Replace(new Received {Id = id});
        }

        /// <summary>
        /// The Request object for message delivery receipts (XEP-0184).
        /// </summary>
        /// <value>
        /// The Request object, or null when this message contains no message delivery request.
        /// </value>
        public Request Request
        {
            get { return Element<Request>(); }
        }
        
        /// <summary>
        /// Gets a value indicating whether message receipt is requested by the sender (XEP-0184).
        /// </summary>
        /// <value>
        ///   <c>true</c> if message receipt requested; otherwise, <c>false</c>.
        /// </value>
        public bool ReceiptRequested
        {
            get { return Request != null; }
        }

        /// <summary>
        /// Gets the message delivery receipt object for message delivery receipts (XEP-0184).
        /// </summary>
        /// <value>
        /// The Received object, or null when this message contains no message delivery receipt.
        /// </value>
        public Received Received
        {
            get { return Element<Received>(); }
        }

        /// <summary>
        /// Gets a value indicating whether the message is or contains a delivery receipt (XEP-0184).
        /// </summary>
        /// <value>
        ///   <c>true</c> if message is or contains a delivery receipt; otherwise, <c>false</c>.
        /// </value>
        public bool IsReceipt
        {
            get { return Received != null; }
        }
        #endregion
        #endregion

        #region << Extension Properties >>
        /// <summary>
        /// Gets or sets the nickname.
        /// </summary>
        /// <value>The nick.</value>
        public Nick Nick
        {
            get { return Element<Nick>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the <see cref="Delay"/>.
        /// </summary>
        /// <value>The delay.</value>
        public Delay.Delay Delay
        {
            get { return Element<Delay.Delay>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the <see cref="XDelay"/>.
        /// </summary>
        /// <value>The X delay.</value>
        public XDelay XDelay
        {
            get { return Element<XDelay>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the Xdata object.
        /// </summary>
        /// <value>The X data.</value>
        public Data XData
        {
            get { return Element<Data>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the X muc user.
        /// </summary>
        /// <value>
        /// The X muc user.
        /// </value>
        public Muc.User.X XMucUser
        {
            get { return Element<Muc.User.X>(); }
            set { Replace(value); }
        }
        
        /// <summary>
        /// Gets or sets the X-HTML object.
        /// </summary>
        /// <value>The X HTML.</value>
        public Html XHtml
        {
            get { return Element<Html>(); }
            set { Replace(value); }
        }

        /// <summary>
        /// Gets or sets the security label (XEP-0258).
        /// </summary>
        /// <value>
        /// The security label.
        /// </value>
        public SecurityLabel SecurityLabel
        {
            get { return Element<SecurityLabel>(); }
            set { Replace(value); }
        }
        
        /// <summary>
        /// Gets or sets the Replace Element (XEP-0308: Last Message Correction).
        /// </summary>
        /// <value>The nick.</value>
        public Replace Replace
        {
            get { return Element<Replace>(); }
            set { Replace(value); }
        }

        #region << Chatstate Properties >>
        /// <summary>
        /// Gets or sets the chatstate.
        /// </summary>
        /// <value>The chatstate.</value>
        public Chatstate Chatstate
        {
            get
            {
                if (Element<Active>() != null)
                    return Chatstate.Active;
                
                if (Element<Inactive>() != null)
                    return Chatstate.Inactive;
                
                if (Element<Composing>() != null)
                    return Chatstate.Composing;
                
                if (Element<Paused>() != null)
                    return Chatstate.Paused;
                
                if (Element<Gone>() != null)
                    return Chatstate.Gone;
                
                return Chatstate.None;
            }
            set
            {
                // remove all chatstates
                RemoveAll<Active>();
                RemoveAll<Inactive>();
                RemoveAll<Composing>();
                RemoveAll<Paused>();
                RemoveAll<Gone>();

                if (value == Chatstate.None)
                    return;

                if (value == Chatstate.Active)
                    Add(new Active());

                if (value == Chatstate.Inactive)
                    Add(new Inactive());

                if (value == Chatstate.Composing)
                    Add(new Composing());

                if (value == Chatstate.Paused)
                    Add(new Paused());

                if (value == Chatstate.Gone)
                    Add(new Gone());
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the addresses.
        /// (XEP-0033: Extended Stanza Addressing)
        /// </summary>
        /// <value>The nick.</value>
        public Addresses Addresses
        {
            get { return Element<Addresses>(); }
            set { Replace(value, true); }
        }

        /// <summary>
        /// SHIM Header (XEP-0131: Stanza Headers and Internet Metadata?)
        /// </summary>
        public Headers Headers
        {
            get { return Element<Headers>(); }
            set { Replace(value, true); }
        }

        /// <summary>
        /// Error object
        /// </summary>
        public Client.Error Error
        {
            get { return Element<Client.Error>(); }
            set { Replace(value); }
        }
        #endregion
    }
}
