using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Bytestreams
{
    [XmppTag(Name = "activate", Namespace = Namespaces.Bytestreams)]
    public class Activate : XmppXElement
    {
        public Activate() : base(Namespaces.Bytestreams, "activate")
        {
        }

        /// <summary>
        /// the full JID of the Target to activate
        /// </summary>
        public Jid Jid
        {
            get
            {
                if (Value == "")
                    return null;
                
                return new Jid(Value);
            }
            set 
            {
                Value = value != null ? value.ToString() : "";
            }
        }
    }
}
