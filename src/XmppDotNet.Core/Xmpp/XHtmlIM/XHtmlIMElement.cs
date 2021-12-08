using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.XHtmlIM
{
    public abstract class XHtmlIMElement : XmppXElement
    {
        protected XHtmlIMElement(string tagName) : base(Namespaces.Xhtml, tagName)
        {
        }
    }
}
