using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Base
{
    public abstract class XmppXElementWithIdAttribute : XmppXElement
    {
        internal XmppXElementWithIdAttribute(string ns, string tagname)
            : base(ns, tagname)
        {
        }

        public string Id
        {
            get => GetAttribute("id");
            set => SetAttribute("id", value);
        }
    }
}
