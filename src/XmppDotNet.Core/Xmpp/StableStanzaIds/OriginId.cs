using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.StableStanzaIds
{
    /// <summary>
    /// Represents a Origin Id
    ///<a href="https://xmpp.org/extensions/xep-0359.html">XEP-0359</a>
    /// Unique and Stable Stanza IDs
    /// </summary>
    [XmppTag(Name = "origin-id", Namespace = Namespaces.StableStanzaIds)]
    public class OriginId : XmppXElementWithIdAttribute
    {
        public OriginId() : base(Namespaces.StableStanzaIds, "origin-id")
        {
        }
    }
}
