using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Bookmarks1
{
    /// <summary>
    ///Rrepresents a conference bookmark extensions.
    /// </summary>
    [XmppTag(Name = "extensions", Namespace = Namespaces.Bookmarks1)]
    public class Extensions : XmppXElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Extensions"/> class.
        /// </summary>
        public Extensions() : base(Namespaces.Bookmarks1, "extensions")
        {
        }
    }
}
