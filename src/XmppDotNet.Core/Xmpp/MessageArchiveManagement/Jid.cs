using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "jid", Namespace = Namespaces.MessageArchiveManagement)]
    public class Jid : XmppXElement
    {
        public Jid() : base(Namespaces.MessageArchiveManagement, "jid")
        {
        }

        public Jid(XmppDotNet.Jid val) : this()
        {
            this.Value = val.Bare;
        }
    }
}