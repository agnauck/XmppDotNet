using XmppDotNet.Xml;
using XmppDotNet.Xmpp.XData;

namespace XmppDotNet.Xmpp.Base
{
    public abstract class XmppXElementWithXData : XmppXElement
    {
        internal XmppXElementWithXData(string ns, string tagname)
            : base(ns, tagname)
        {
        }

        /// <summary>
        /// Gets or sets the Xdata object.
        /// </summary>
        /// <value>The X data.</value>
        public Data XData
        {
            get { return Element<Data>(); }
            set { Replace(value); }
        }
    }
}
