using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Sasl2
{
    [XmppTag(Name = "inline", Namespace = Namespaces.Sasl2)]
    public class Inline : XmppXElement
    {
        public Inline()
            : base(Namespaces.Sasl2, "inline")
        {
        }
        
        /// <summary>
        /// The <see cref="Bind2.Bind"/> Element
        /// </summary>
        public Bind2.Bind Bind
        {
            get { return Element<Bind2.Bind>(); }
            set { Replace(value); }
        }
    }
}
