using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.StableStanzaIds
{
    /// <summary>
    /// Represents a Stanza Id
    ///<a href="https://xmpp.org/extensions/xep-0359.html">XEP-0359</a>
    /// Unique and Stable Stanza IDs
    /// </summary>
    [XmppTag(Name = "stanza-id", Namespace = Namespaces.StableStanzaIds)]
    public class StanzaId : XmppXElementWithIdAttribute
    {
        public StanzaId() : base(Namespaces.StableStanzaIds, "stanza-id")
        {
        }
        
        /// <summary>
        /// Specifies the target domain of the first stream.
        /// </summary>
        public Jid By
        {
            get => GetAttributeJid("by");
            set => SetAttribute("by", value);
        }
    }
}