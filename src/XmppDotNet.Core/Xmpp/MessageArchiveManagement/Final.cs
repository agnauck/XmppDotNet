using XmppDotNet.Xmpp.Base;
using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.ResultSetManagement;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "fin", Namespace = Namespaces.MessageArchiveManagement)]
    public class Final : XmppXElementWithResultSet
    {
        public Final() : base(Namespaces.MessageArchiveManagement, "fin")
        {
        }

        /// <summary>
        /// Gets or sets a value to indicate whether the result is complete or not
        /// </summary>
        public bool Complete
        {
            get => GetAttributeBool("complete");
            set => SetAttribute("complete", value);
        }
    }
}