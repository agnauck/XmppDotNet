namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-protocol-pubsubnode_config

        /// <summary>
        /// list-single	Who may subscribe and retrieve items
        /// </summary>
        public const string PubsubNodeConfigAccessModel = "pubsub#access_model";

        /// <summary>
        /// text-single	The URL of an XSL transformation which can be applied to payloads in order
        /// to generate an appropriate message body element.
        /// </summary>
        public const string PubsubNodeConfigBodyXslt = "pubsub#body_xslt";

        /// <summary>
        /// text-single	The collection with which a node is affiliated
        /// </summary>
        public const string PubsubNodeConfigCollection = "pubsub#collection";

        /// <summary>
        ///	jid-multi	The JIDs of those to contact with questions
        /// </summary>
        public const string PubsubNodeConfigContact = "pubsub#contact";

        /// <summary>
        /// text-single	The URL of an XSL transformation which can be applied to the payload format in order 
        /// to generate a valid Data Forms result that the client could display using a generic Data Forms rendering engine
        /// </summary>
        public const string PubsubNodeConfigpubsubDataformXslt = "pubsub#dataform_xslt";

        /// <summary>
        /// boolean	Whether to deliver event notifications
        /// </summary>
        public const string PubsubNodeConfigDeliverNotifications = "pubsub#deliver_notifications";

        /// <summary>
        /// boolean	Whether to deliver payloads with event notifications; applies only to leaf nodes
        /// </summary>
        public const string PubsubNodeConfigDeliverPayloads = "pubsub#deliver_payloads";

        /// <summary>
        /// list-single	Whether owners or publisher should receive replies to items
        /// </summary>
        public const string PubsubNodeConfigItemReply = "pubsub#itemreply";

        /// <summary>
        /// list-single	Who may associate leaf nodes with a collection
        /// </summary>
        public const string PubsubNodeConfigChildrenAssociationPolicy = "pubsub#children_association_policy";

        /// <summary>
        /// jid-multi	The list of JIDs that may associate leaf nodes with a collection
        /// </summary>
        public const string PubsubNodeConfigChildrenAssociationWhitelist = "pubsub#children_association_whitelist";

        /// <summary>
        /// text-multi	The child nodes (leaf or collection) associated with a collection
        /// </summary>
        public const string PubsubNodeConfigChildren = "pubsub#children";

        /// <summary>
        /// text-single	The maximum number of child nodes that can be associated with a collection
        /// </summary>
        public const string PubsubNodeConfigChildrenMax = "pubsub#children_max";

        /// <summary>
        /// text-single	The maximum number of items to persist
        /// </summary>
        public const string PubsubNodeConfigMaxItems = "pubsub#max_items";

        /// <summary>
        /// text-single	The maximum payload size in bytes
        /// </summary>
        public const string PubsubNodeConfigMaxPayloadSize = "pubsub#max_payload_size";

        /// <summary>
        /// list-single	Whether the node is a leaf (default) or a collection
        /// </summary>
        public const string PubsubNodeConfigNodeType = "pubsub#node_type";

        /// <summary>
        /// boolean	Whether to notify subscribers when the node configuration changes
        /// </summary>
        public const string PubsubNodeConfigNotifyConfig = "pubsub#notify_config";

        /// <summary>
        /// boolean	Whether to notify subscribers when the node is deleted
        /// </summary>
        public const string PubsubNodeConfigNotifyDelete = "pubsub#notify_delete";

        /// <summary>
        /// boolean	Whether to notify subscribers when items are removed from the node
        /// </summary>
        public const string PubsubNodeConfigNotifyRetract = "pubsub#notify_retract";

        /// <summary>
        ///	boolean	Whether to notify owners about new subscribers and unsubscribes
        /// </summary>
        public const string PubsubNodeConfigNotifySub = "pubsub#notify_sub";

        /// <summary>
        ///	boolean	Whether to persist items to storage 
        /// </summary>
        public const string PubsubNodeConfigPersistItems = "pubsub#persist_items";

        /// <summary>
        /// boolean	Whether to deliver notifications to available users only
        /// </summary>
        public const string PubsubNodeConfigPresenceBasedDelivery = "pubsub#presence_based_delivery";

        /// <summary>
        /// list-single	The publisher model
        /// </summary>
        public const string PubsubNodeConfigPublishModel = "pubsub#publish_model";

        /// <summary>
        /// jid-multi	The specific multi-user chat rooms to specify for replyroom
        /// </summary>
        public const string PubsubNodeConfigReplyRoom = "pubsub#replyroom";

        /// <summary>
        /// jid-multi	The specific JID(s) to specify for replyto
        /// </summary>
        public const string PubsubNodeConfigReplyto = "pubsub#replyto";

        /// <summary>
        /// list-multi	The roster group(s) allowed to subscribe and retrieve items
        /// </summary>
        public const string PubsubNodeConfigRosterGroupsAllowed = "pubsub#roster_groups_allowed";
        
        /// <summary>
        /// list-single	When to send the last published item
        /// </summary>
        public const string PubsubNodeConfigSendLastPublishedItem = "pubsub#send_last_published_item";

        /// <summary>
        /// boolean	Whether to allow subscriptions
        /// </summary>
        public const string PubsubNodeConfigSubscribe = "pubsub#subscribe";

        /// <summary>
        /// text-single	A friendly name for the node
        /// </summary>
        public const string PubsubNodeConfigTitle = "pubsub#title";

        /// <summary>
        /// text-single	The type of node data, usually specified by the namespace of the payload (if any); MAY be list-single rather than text-single
        /// </summary>
        public const string PubsubNodeConfigType = "pubsub#type";
    }
}
