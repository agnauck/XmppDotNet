using XmppDotNet.Attributes;
using XmppDotNet.Crypt;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Component
{
    [XmppTag(Name = "handshake", Namespace = Namespaces.Accept)]
    public class Handshake  : XmppXElement
    {
        public Handshake() : base(Namespaces.Accept, "handshake")
        {
        }

        public Handshake(string streamid, string password)
            : this()
        {
            Value = Hash.Sha1HashHex(streamid + password);
        }
    }
}
