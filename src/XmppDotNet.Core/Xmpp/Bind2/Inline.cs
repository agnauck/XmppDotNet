using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Disco;

namespace XmppDotNet.Xmpp.Bind2
{
    [XmppTag(Name = "inline", Namespace = Namespaces.Bind2)]
    public class Inline : FeatureContainer
    {
        public Inline() : base(Namespaces.Bind2, "inline")
        {
        }

        public bool SupportMessageCarbons => HasFeature(Namespaces.MessageCarbons);
        public bool SupportsStreamManagement => HasFeature(Namespaces.FeatureStreamManagement);
        public bool SupportsClientStateIndication => HasFeature(Namespaces.ClientStateIndication);
    }
}