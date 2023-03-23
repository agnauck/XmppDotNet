namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-protocol-pubsubsubscribe_authorization

        /// <summary>
        /// boolean	Whether to allow the subscription
        /// </summary>
        public const string PubsubSubscribeAuthorizationAllow = "pubsub#allow";

        /// <summary>
        /// text-single	The SubID of the subscription
        /// </summary>
        public const string PubsubSubscribeAuthorizationSubId = "pubsub#subid";

        /// <summary>
        /// text-single	The NodeID of the relevant node
        /// </summary>
        public const string PubsubSubscribeAuthorizationNode = "pubsub#node";

        /// <summary>
        /// jid-single	The address (JID) of the subscriber
        /// </summary>
        public const string PubsubSubscribeAuthorizationSubscriberJid = "pubsub#subscriber_jid";
    }
}
