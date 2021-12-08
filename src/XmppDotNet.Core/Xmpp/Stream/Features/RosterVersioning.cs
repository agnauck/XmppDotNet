using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Stream.Features
{
    [XmppTag(Name = "ver", Namespace = Namespaces.FeatureRosterVersioning)]
    public class RosterVersioning : StreamFeature
    {
        public RosterVersioning() : base(Namespaces.FeatureRosterVersioning, "ver")
        {
        }
    }
}
