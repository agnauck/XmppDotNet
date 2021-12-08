using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.Google.Push
{
    #region Xml sample
    /*
        <subscribe xmlns="google:push">
		    <item channel="cloudprint.google.com" from="cloudprint.google.com"/>
	    </subscribe>
    */
    #endregion

    [XmppTag(Name = "subscribe", Namespace = Namespaces.GooglePush)]
    public class Subscribe : XmppXElement
    {
        public Subscribe() : base(Namespaces.GooglePush, "subscribe")
        {
        }
    }
}
