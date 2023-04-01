namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/extensions/xep-0045.html#registrar-formtype-roominfo

        /// <summary>
        /// jid-multi, contact addresses (normally, room owner or owners)
        /// </summary>
        public const string MucRoomInfoContactJid = "muc#roominfo_contactjid";

        /// <summary>
        /// text-single, short description of room
        /// </summary>
        public const string MucRoomInfoDescription = "muc#roominfo_description";

        /// <summary>
        /// text-single, natural language for room discussions
        /// </summary>
        public const string MucRoomInfoLanguage = "muc#roominfo_lang";

        /// <summary>
        /// text-single, an associated LDAP group that defines room membership; this should be an LDAP
        /// Distinguished Name according to an implementation-specific or
        /// deployment-specific definition of a group.
        /// </summary>
        public const string MucRoomInfoLdapGroup = "muc#roominfo_ldapgroup";

        /// <summary>
        /// text-single, URL for archived discussion logs
        /// </summary>
        public const string MucRoomInfoLogs = "muc#roominfo_logs";


        /// <summary>
        /// text-single, current number of occupants in room
        /// </summary>
        public const string MucRoomInfoOccupants = "muc#roominfo_occupants";

        /// <summary>
        /// text-single, current discussion topic
        /// </summary>
        public const string MucRoomInfoSubject = "muc#roominfo_subject";

        /// <summary>
        /// boolean, the room subject can be modified by participants
        /// </summary>
        public const string MucRoomInfoSubjectMod = "muc#roominfo_subjectmod";

    }
}
