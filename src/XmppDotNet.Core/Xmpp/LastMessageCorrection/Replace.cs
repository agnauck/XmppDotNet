using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.LastMessageCorrection
{
    /// <summary>
    /// XEP-0308: Last Message Correction
    /// </summary>
    [XmppTag(Name = "replace", Namespace = Namespaces.LastMessageCorrection)]
    public class Replace : XmppXElementWithIdAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Replace"/> class.
        /// </summary>
        public Replace() : base(Namespaces.LastMessageCorrection, "replace")
        {
        }
    }
}
