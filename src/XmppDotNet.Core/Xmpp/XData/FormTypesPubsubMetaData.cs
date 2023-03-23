namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-protocol-pubsubmeta-data

        /// <summary>
        /// jid-multi	The JIDs of those to contact with questions
        /// </summary>
        public const string PubsubMetaDataContact = "pubsub#contact";

        /// <summary>
        /// text-single	The datetime when the node was created
        /// </summary>
        public const string PubsubMetaDataCreationDate = "pubsub#creation_date";

        /// <summary>
        /// jid-single	The JID of the node creator
        /// </summary>
        public const string PubsubMetaDataCreator = "pubsub#creator";

        /// <summary>
        /// text-single	A description of the node
        /// </summary>
        public const string PubsubMetaDataDescription = "pubsub#description";

        /// <summary>
        /// text-single	The default language of the node
        /// </summary>
        public const string PubsubMetaDataLanguage = "pubsub#language";

        /// <summary>
        /// text-single	The number of subscribers to the node
        /// </summary>
        public const string PubsubMetaDataNumberOfSubscribers = "pubsub#num_subscribers";

        /// <summary>
        /// jid-multi	The JIDs of those with an affiliation of owner
        /// </summary>
        public const string PubsubMetaDataOwner = "pubsub#owner";

        /// <summary>
        /// jid-multi	The JIDs of those with an affiliation of publisher
        /// </summary>
        public const string PubsubMetaDataPublisher = "pubsub#publisher";

        /// <summary>
        /// text-single	The name of the node
        /// </summary>
        public const string PubsubMetaDataTitle = "pubsub#title";

        /// <summary>
        /// text-single	Payload type
        /// </summary>
        public const string PubsubMetaDataType = "pubsub#type";
    }
}
