using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Sasl2
{
    /// <summary>
    /// Sasl2 failure object.
    /// </summary>
    [XmppTag(Name = "failure", Namespace = Namespaces.Sasl2)]
    public class Failure : Sasl.Failure
    {
        public Failure() : base(Namespaces.Sasl2)
        {
        }
    }
}
