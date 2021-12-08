using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiving
{
    [XmppTag(Name = "save", Namespace = Namespaces.Archiving)]
    public class Save : ArchiveBase
    {
        public Save() : base("save")
        {
        }
    }
}
