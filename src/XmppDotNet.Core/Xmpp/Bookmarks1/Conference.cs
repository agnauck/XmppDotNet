using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Bookmarks1
{
    /// <summary>
    ///Rrepresents a conference bookmark.
    /// </summary>
    [XmppTag(Name = "conference", Namespace = Namespaces.Bookmarks1)]
    public class Conference : XmppXElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conference"/> class.
        /// </summary>
        public Conference() : base(Namespaces.Bookmarks1, "conference")
        {
        }

        /// <summary>
        /// A name/description for this bookmarked room
        /// </summary>
        public new string Name
        {
            get { return GetAttribute("name"); }
            set { SetAttribute("name", value); }
        }

        /// <summary>
        /// Should the client join this room automatically after successfuil login?
        /// </summary>
        public bool AutoJoin
        {
            get { return GetAttributeBool("autojoin"); }
            set { SetAttribute("autojoin", value); }
        }

        /// <summary>
        /// The Nickname for this room
        /// </summary>
        public string Nickname
        {
            get { return GetTag("nick"); }
            set { SetTag("nick", value); }
        }

        /// <summary>
        /// The password for password protected rooms
        /// </summary>
        public string Password
        {
            get { return GetTag("password"); }
            set { SetTag("password", value); }
        }

        /// <summary>
        /// The <see cref="Extensions"/>
        /// </summary>
        public Extensions Extensions
        {
            get { return Element<Extensions>(); }
            set { Replace(value); }
        }
    }
}
