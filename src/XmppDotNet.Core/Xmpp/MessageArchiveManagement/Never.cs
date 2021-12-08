using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "never", Namespace = Namespaces.MessageArchiveManagement)]
    public class Never : PolicyBase
    {
        public Never() : base("never")
        {
        }
    }
}