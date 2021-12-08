using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Stream.Features;

namespace XmppDotNet.Xmpp.Tls
{
    /// <summary>
    /// StartTls object
    /// </summary>
    [XmppTag(Name = Tag.StartTls, Namespace = Namespaces.Tls)]
    public class StartTls : StreamFeature
    {
        public StartTls()
            : base(Namespaces.Tls, Tag.StartTls)
        {            
        }
    }
}
