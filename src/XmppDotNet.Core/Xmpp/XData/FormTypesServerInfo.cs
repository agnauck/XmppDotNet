namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-network-serverinfo
        
       
        /// <summary>
        /// list-multi One or more addresses for communication related to abusive traffic
        /// </summary>
        public const string ServerInfoAbuseAddresses = "abuse-addresses";

        /// <summary>
        /// list-multi One or more addresses for communication with the service administrators
        /// </summary>
        public const string ServerInfoAdminAddresses = "admin-addresses";

        /// <summary>
        /// list-multi One or more addresses for customer feedback
        /// </summary>
        public const string ServerInfoFeedbackAddresses = "feedback-addresses";

        /// <summary>
        /// list-multi One or more addresses for communication related to sales and marketing
        /// </summary>
        public const string ServerInfoSalesAddresses = "sales-addresses";

        /// <summary>
        /// list-multi One or more addresses for communication related to security concerns
        /// </summary>
        public const string ServerInfoSecurityAddresses = "security-addresses";

        /// <summary>
        /// list-multi One or more addresses for customer support
        /// </summary>
        public const string ServerInfoSupportAddresses = "support-addresses";
    }
}
