using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Bind2
{
    [XmppTag(Name = Xmpp.Tag.Bind, Namespace = Namespaces.Bind2)]
    public class Bind : XmppXElement
    {
        public Bind() : base(Namespaces.Bind2, Xmpp.Tag.Bind)
        {
        }
        
        public string Tag
        {
            get { return GetTag("tag"); }
            set { SetTag("tag", value); }
        }
        
        /// <summary>
        /// The <see cref="Inline"/> Element
        /// </summary>
        public Inline Inline
        {
            get { return Element<Inline>(); }
            set { Replace(value); }
        }
    }
}