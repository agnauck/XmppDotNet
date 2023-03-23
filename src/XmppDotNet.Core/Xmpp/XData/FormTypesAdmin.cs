namespace XmppDotNet.Xmpp.XData
{
    /// <summary>
    /// FORM_TYPEs for Data Forms
    /// </summary>
    public partial class FormTypes
    {
        // https://xmpp.org/registrar/formtypes.html#http:--jabber.org-protocol-admin

        /// <summary>
        ///  jid-single The Jabber ID of a single entity to which an operation applies
        /// </summary>
        public const string AdminAccountJid = "accountjid";

        /// <summary>
        ///  jid-multi The Jabber ID of one or more entities to which an operation applies
        /// </summary>
        public const string AdminAccountJids = "accountjids";

        /// <summary>
        /// jid-multi The Jabber IDs associated with active sessions
        /// </summary>
        public const string AdminActiveUserJids = "activeuserjids";

        /// <summary>
        ///  text-single The number of online entities that are active
        /// </summary>
        public const string AdminActiveUsersNumber = "activeusersnum";

        /// <summary>
        /// jid-multi A list of entities with administrative privileges
        /// </summary>
        public const string AdminAdminJids = "adminjids";

        /// <summary>
        ///  text-multi The text of an announcement to be sent to active users or all users
        /// </summary>
        public const string AdminAnnouncement = "announcement";

        /// <summary>
        ///  jid-multi A list of entities with whom communication is blocked
        /// </summary>
        public const string AdminBlacklistJids = "blacklistjids";

        /// <summary>
        ///  list-multi The number of seconds to delay before applying a change
        /// </summary>
        public const string AdminDelay = "delay";

        /// <summary>
        ///  jid-multi The Jabber IDs that have been disabled
        /// </summary>
        public const string AdminDisabledUserJids = "disableduserjids";

        /// <summary>
        /// text-single The number of disabled entities
        /// </summary>
        public const string AdminDisabledUsersNumber = "disabledusersnum";

        /// <summary>
        ///  text-single The email address for a user
        /// </summary>
        public const string AdminEmail = "email";

        /// <summary>
        ///  text-single The given(first) name of a user
        /// </summary>
        public const string AdminGivenName = "given_name";

        /// <summary>
        ///  text-single The number of online entities that are idle
        /// </summary>
        public const string AdminIdleUsersNumber = "idleusersnum";

        /// <summary>
        ///  list-multi The IP addresses of an account's online sessions
        /// </summary>
        public const string AdminIpAddresses = "ipaddresses";
        /// <summary>
        ///  text-single The last login time(per XEP-0082) of a user
        /// </summary>
        public const string AdminLastLogin = "lastlogin";

        /// <summary>
        ///  text-single The number of logins per minute for an account
        /// </summary>
        public const string AdminLoginsPerMinute = "loginsperminute";

        /// <summary>
        /// list-single The maximum number of items associated with a search or list
        /// </summary>
        public const string AdminMaxItems = "max_items";

        /// <summary>
        ///  text-multi The text of a message of the day
        /// </summary>
        public const string AdminMessageOfTheDay = "motd";

        /// <summary>
        ///  text-single The names of an account's online sessions
        /// </summary>
        public const string AdminOnlineResources = "onlineresources";

        /// <summary>
        ///  jid-multi The Jabber IDs associated with online users
        /// </summary>
        public const string AdminOnlineUserJids = "onlineuserjids";

        /// <summary>
        ///  text-single The number of online entities
        /// </summary>
        public const string AdminOnlineUsersNumber = "onlineusersnum";

        /// <summary>
        /// text-private The password for an account
        /// </summary>
        public const string AdminPassword = "password";

        /// <summary>
        ///  text-private Password verification
        /// </summary>
        public const string AdminPasswordVerification = "password-verify";

        /// <summary>
        ///  jid-multi A list of registered entities
        /// </summary>
        public const string AdminRegisteredUserJids = "registereduserjids";

        /// <summary>
        /// text-single The number of registered entities
        /// </summary>
        public const string AdminRegisteredUsersNumber = "registeredusersnum";

        /// <summary>
        ///  text-single Number of roster items for an account
        /// </summary>
        public const string AdminRosterSize = "rostersize";

        /// <summary>
        ///  text-single The number of stanzas being sent per second by an account
        /// </summary>
        public const string AdminStanzasPerSecond = "stanzaspersecond";

        /// <summary>
        ///  text-single The family(last) name of a user
        /// </summary>
        public const string AdminSurname = "surname";

        /// <summary>
        ///  text-multi The text of a welcome message
        /// </summary>
        public const string AdminWelcome = "welcome";

        /// <summary>
        ///  jid-multi A list of entities with whom communication is allowed
        /// </summary>
        public const string AdminWhitelistJids = "whitelistjids";
    }
}
