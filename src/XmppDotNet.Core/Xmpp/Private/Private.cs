using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Bookmarks;

namespace XmppDotNet.Xmpp.Private
{
    [XmppTag(Name = Tag.Query, Namespace = Namespaces.IqPrivate)]
    public class Private : XmppXElement
    {
        public Private() : base(Namespaces.IqPrivate, Tag.Query)
        {
        }

        public Storage Storage
        {
            get { return Element<Storage>(); }
            set { Replace(value); }
        }
    }
}
