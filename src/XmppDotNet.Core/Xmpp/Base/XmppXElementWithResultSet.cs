using XmppDotNet.Xml;
using XmppDotNet.Xmpp.ResultSetManagement;

namespace XmppDotNet.Xmpp.Base
{
    public abstract class XmppXElementWithResultSet : XmppXElement
    {
        protected XmppXElementWithResultSet(string ns, string tagname) : base(ns, tagname)
        {
        }
        
        /// <summary>
        /// Gets or sets the result set.
        /// </summary>
        /// <value>
        /// The result set.
        /// </value>
        public Set ResultSet
        {
            get => Element<Set>();
            set => Replace(value);
        }
    }
}
