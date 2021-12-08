using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Jingle.Transports
{
    [XmppTag(Name = "transport", Namespace = Namespaces.JingleTransportIbb)]
    public class TransportIbb : IBB.Open
    {
        public TransportIbb() : base(Namespaces.JingleTransportIbb, "transport")
        {}
    }
}
