using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.XData
{
    [XmppTag(Name = "value", Namespace = Namespaces.XData)]
    public class Value : XmppXElement
    {
        public Value() : base(Namespaces.XData, "value")
        {            
        }

        public Value(string val)
            : this()
        {
            Value = val;
        }

        public Value(bool val)
            : this()
        {
            Value = val ? "1" : "0";
        }
    }
}
