using System;

namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html

        /// <summary>
        ///  text-single Given Name
        /// </summary>
        public const string MucRegisterFirst = "muc#register_first";

        /// <summary>
        ///  text-single Family Name
        /// </summary>
        public const string MucRegisterLast = "muc#register_last";

        /// <summary>
        /// text-single Desired Nickname
        /// </summary>
        public const string MucRegisterRoomNick = "muc#register_roomnick";

        /// <summary>
        /// text-single Your URL
        /// </summary>
        public const string MucRegisterUrl = "muc#register_url";

        /// <summary>
        /// text-single Email Address
        /// </summary>
        public const string MucRegisterEmail = "muc#register_email";

        /// <summary>
        /// text-multi FAQ Entry
        /// </summary>
        public const string MucRegisterFaqEntry = "muc#register_faqentry";
    }
}
