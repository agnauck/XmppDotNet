namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-protocol-pubsubsubscribe_options

        /// <summary>
        /// boolean Whether an entity wants to receive or disable notifications
        /// </summary>
        public const string PubsubSubscribeOptionsDeliver = "pubsub#deliver";

        /// <summary>
        /// boolean Whether an entity wants to receive digests(aggregations) of notifications or all notifications individually
        /// </summary>
        public const string PubsubSubscribeOptionsDigest = "pubsub#digest";

        /// <summary>
        /// text-single The minimum number of milliseconds between sending any two notification digests
        /// </summary>
        public const string PubsubSubscribeOptionsDigestFrequency = "pubsub#digest_frequency";

        /// <summary>
        /// text-single The DateTime at which a leased subscription will end or has ended
        /// </summary>
        public const string PubsubSubscribeOptionsExpire = "pubsub#expire";

        /// <summary>
        /// boolean Whether an entity wants to receive an XMPP message body in addition to the payload format
        /// </summary>
        public const string PubsubSubscribeOptionsIncludeBody = "pubsub#include_body";

        /// <summary>
        /// list-multi The presence states for which an entity wants to receive notifications
        /// </summary>
        public const string PubsubSubscribeOptionsShow = "pubsub#show-values";

        /// <summary>
        /// list-single
        /// </summary>
        public const string PubsubSubscribeOptionssubscriptionType = "pubsub#subscription_type";

        /// <summary>
        /// list-single
        /// </summary>
        public const string PubsubSubscribeOptionsSubscriptionDepth = "pubsub#subscription_depth";
    }
}
