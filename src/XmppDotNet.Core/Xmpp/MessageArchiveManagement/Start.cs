using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "start", Namespace = Namespaces.MessageArchiveManagement)]
    public class Start : XmppXElementWithIdAndTimestampAttribute
    {
        public Start() : base(Namespaces.MessageArchiveManagement, "start")
        {
        }
    }
}
