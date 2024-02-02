using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "end", Namespace = Namespaces.MessageArchiveManagement)]
    public class End: XmppXElementWithIdAndTimestampAttribute
    {
        public End() : base(Namespaces.MessageArchiveManagement, "end")
        {
        }
    }
}
