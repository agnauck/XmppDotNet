using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "metadata", Namespace = Namespaces.MessageArchiveManagement)]
    public class MetaData : XmppXElement
    {
        public MetaData() : base(Namespaces.MessageArchiveManagement, "metadata")
        {
        }
        
        public Start Start
        {
            get { return Element<Start>(); }
            set { Replace(value); }
        }
     
        public End End
        {
            get { return Element<End>(); }
            set { Replace(value); }
        }
    }
}
