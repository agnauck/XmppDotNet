using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.MessageArchiveManagement;

namespace XmppDotNet.Xmpp.Bind2
{
    [XmppTag(Name = "bound", Namespace = Namespaces.Bind2)]
    public class Bound : XmppXElement
    {
        public Bound() : base(Namespaces.Bind2, "bound")
        {
        }
        
        /// <summary>
        /// Gets or Sets the <see cref="MetaData"/> Element
        /// </summary>
        public MetaData MetaData
        {
            get { return Element<MetaData>(); }
            set { Replace(value); }
        }
    }
}
