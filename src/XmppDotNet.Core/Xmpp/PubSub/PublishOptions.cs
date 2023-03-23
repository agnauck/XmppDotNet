using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.PubSub
{
    [XmppTag(Name = "publish-options", Namespace = Namespaces.Pubsub)]
    public class PublishOptions : Base.XmppXElementWithXData
    {      
        public PublishOptions()
            : base(Namespaces.Pubsub, "publish-options")
        {
        }
    }
}
