using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.StableStanzaIds
{
    /// <summary>
    /// Represents a referenced stanza
    ///<a href="https://xmpp.org/extensions/xep-0359.html">XEP-0359</a>
    /// Unique and Stable Stanza IDs
    /// </summary>
    [XmppTag(Name = "referenced-stanza", Namespace = Namespaces.StableStanzaIds)]
    public class ReferencedStanzaId : XmppXElementWithIdAttribute
    {
        public ReferencedStanzaId() : base(Namespaces.StableStanzaIds, "referenced-stanza")
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