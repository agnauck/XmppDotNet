using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.AdvancedMessageProcessing
{
    public enum Condition
    {
        /// <summary>
        /// Namespace: http://jabber.org/protocol/amp?condition=deliver
        /// Syntax: [direct|forward|gateway|none|stored]
        /// Processing: The condition is met if (1) the value is "direct" and the message can be immediately delivered or further dispatched, or (2) the value is "stored" and offline storage is enabled.
        /// Per-Hop: true
        /// </summary>
        [Name("deliver")]
        Deliver,

        /// <summary>
        /// Namespace: http://jabber.org/protocol/amp?condition=expire-at
        /// Syntax: DateTime per XEP-0082
        /// Processing: The condition is met if the message cannot be delivered before the specified DateTime.
        /// Per-Hop: true
        /// </summary>
        [Name("expire-at")]
        ExpireAt,

        /// <summary>
        /// Namespace: http://jabber.org/protocol/amp?condition=match-resource
        /// Syntax: [any|exact|other]
        /// Processing: The condition is met if (1) the value is "any" and the intended recipient has at least one available resource (as defined in the XMPP IM specification); (2) the value "exact" and the intended recipient has an available resource that exactly matches the JID specified in the 'to' address; (3) the value is "other" and the intended recipient has an available resource whose full JID is other than that specified in the 'to' address.
        /// Per-Hop: false
        /// </summary>
        [Name("match-resource")]
        MatchResource
    }
}
