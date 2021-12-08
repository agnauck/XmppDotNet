using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.Blocking
{
    [XmppTag(Name = Tag.Item, Namespace = Namespaces.Blocking)]
    public class Item : XmppXElementWithJidAttribute
    {
        public Item() : base(Namespaces.Blocking, "item")
        {}
    }
}
