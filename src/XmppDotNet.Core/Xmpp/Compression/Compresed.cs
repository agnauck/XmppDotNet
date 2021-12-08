using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Compression
{
    [XmppTag(Name = "compressed", Namespace = Namespaces.Compress)]
    public class Compresed : XmppXElement
    {
        public Compresed()
            : base(Namespaces.Compress, "compressed")
        {
        }
    }
}
