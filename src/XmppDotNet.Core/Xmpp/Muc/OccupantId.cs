using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.Muc
{
    /// <summary>
    /// Represents a XEP-0421 Occupant Id
    /// </summary>
    [XmppTag(Name = "occupant-id", Namespace = Namespaces.OccupantId)]
    public class OccupantId : XmppXElementWithIdAttribute
    {
        public OccupantId()
            : base(Namespaces.OccupantId, "occupant-id")
        {
        }
    }
}
