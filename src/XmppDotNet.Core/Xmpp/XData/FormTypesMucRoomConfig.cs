namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html

        /// <summary>
        /// boolean Whether to Allow Occupants to Invite Others
        /// </summary>
        public const string MucRoomConfigAllowInvites = "muc#roomconfig_allowinvites";

        /// <summary>
        /// boolean Whether to Allow Occupants to Change Subject
        /// </summary>
        public const string MucRoomConfigChangeSubject = "muc#roomconfig_changesubject";

        /// <summary>
        ///  boolean Whether to Enable Logging of Room Conversations
        /// </summary>
        public const string MucRoomConfigEnableLogging = "muc#roomconfig_enablelogging";

        /// <summary>
        /// text-single Natural Language for Room Discussions
        /// </summary>
        public const string MucRoomConfigLanguage = "muc#roomconfig_lang";

        /// <summary>
        ///  list-single Maximum Number of Room Occupants
        /// </summary>
        public const string MucRoomConfigMaxUsers = "muc#roomconfig_maxusers";

        /// <summary>
        ///  boolean Whether an Make Room Members-Only
        /// </summary>
        public const string MucRoomConfigMembersOnly = "muc#roomconfig_membersonly";

        /// <summary>
        ///  boolean Whether to Make Room Moderated
        /// </summary>
        public const string MucRoomConfigModeratedRoom = "muc#roomconfig_moderatedroom";

        /// <summary>
        ///  boolean Whether a Password is Required to Enter
        /// </summary>
        public const string MucRoomConfigPasswordProtectedRoom = "muc#roomconfig_passwordprotectedroom";

        /// <summary>
        /// boolean Whether to Make Room Persistent
        /// </summary>
        public const string MucRoomConfigPersistentRoom = "muc#roomconfig_persistentroom";

        /// <summary>
        /// list-multi Roles for which Presence is Broadcast
        /// </summary>
        public const string MucRoomConfigPresenceBroadcast = "muc#roomconfig_presencebroadcast";

        /// <summary>
        /// boolean Whether to Allow Public Searching for Room
        /// </summary>
        public const string MucRoomConfigPublicRoom = "muc#roomconfig_publicroom";

        /// <summary>
        /// jid-multi Full List of Room Admins
        /// </summary>
        public const string MucRoomConfigRoomAdmins = "muc#roomconfig_roomadmins";

        /// <summary>
        /// text-single Short Description of Room
        /// </summary>
        public const string MucRoomConfigRoomDescription = "muc#roomconfig_roomdesc";

        /// <summary>
        /// text-single Natural-Language Room Name
        /// </summary>
        public const string MucRoomConfigRoomName = "muc#roomconfig_roomname";

        /// <summary>
        /// jid-multi Full List of Room Owners
        /// </summary>
        public const string MucRoomConfigRoomOwners = "muc#roomconfig_roomowners";

        /// <summary>
        ///  text-private"	The Room Password
        /// </summary>
        public const string MucRoomConfigRoomSecret = "muc#roomconfig_roomsecret";

        /// <summary>
        /// list-single Affiliations that May Discover Real JIDs of Occupants
        /// </summary>
        public const string MucRoomConfigWhois = "muc#roomconfig_whois";
    }
}
