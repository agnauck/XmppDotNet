using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    public abstract class CarbonBase : XmppXElement
    {
        protected CarbonBase(string tag) : base(Namespaces.MessageCarbons, tag)
        {
        }
    }
}
