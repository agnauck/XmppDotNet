using System;

namespace XmppDotNet.Xmpp.Base
{
    public abstract class XmppXElementWithIdAndTimestampAttribute : XmppXElementWithIdAttribute
    {
        internal XmppXElementWithIdAndTimestampAttribute(string ns, string tagname)
            : base(ns, tagname)
        {
        }
        
        /// <summary>
        /// UTC timestamp specifying the moment when the reading was taken.
        /// </summary>
        public DateTime Timestamp
        {
            get { return XmppDotNet.Time.Iso8601Date(GetAttribute("timestamp")); }
            set { SetAttribute("timestamp", XmppDotNet.Time.Iso8601Date(value)); }
        }
    }
}
