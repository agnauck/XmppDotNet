using XmppDotNet.Attributes;
using XmppDotNet.Xmpp.Forward;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = "result", Namespace = Namespaces.MessageArchiveManagement)]
    public class Result : MessageArchive
    {
        public Result() : base("result")
        {
        }

        /// <summary>
        /// Get or sets the id
        /// </summary>
        public string Id
        {
            get => GetAttribute("id");
            set => SetAttribute("id", value);
        }
        
        /// <summary>
        /// Gets or sets the forwarded.
        /// </summary>
        /// <value>
        /// The forwarded.
        /// </value>
        public Forwarded Forwarded
        {
            get => Element<Forwarded>();
            set => Replace(value);
        }
    }
}