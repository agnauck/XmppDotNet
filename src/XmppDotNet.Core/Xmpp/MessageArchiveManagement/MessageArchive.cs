using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Base;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    [XmppTag(Name = Tag.Query, Namespace = Namespaces.MessageArchiveManagement)]
    public class MessageArchive : XmppXElementWithResultSetAndXData
    {
        protected MessageArchive(string tagName)
            : base(Namespaces.MessageArchiveManagement, tagName)
        {
        }

        public MessageArchive() : base(Namespaces.MessageArchiveManagement, Tag.Query)
        {
        }

        /// <summary>
        /// Get or sets the query id
        /// </summary>
        public string QueryId
        {
            get => GetAttribute("queryid");
            set => SetAttribute("queryid", value);
        }


        /// <summary>
        /// Get or sets the query node
        /// </summary>
        public string Node
        {
            get => GetAttribute("node");
            set => SetAttribute("node", value);
        }

        /// <summary>
        /// Gets or sets a value indicating whether the order of the results should
        /// be in normal or reverse order.
        /// When fetching a page, the client may prefer for the server to send
        /// the results within that page in reverse order. For example, if a client
        /// implements a user interface that automatically fetches older messages
        /// as a user scrolls backward, it may want to receive and display the newest
        /// messages first, instead of waiting for the whole page to be received.
        /// </summary>
        /// <value><c>true</c> if flipped (reverse); otherwise, <c>false</c>.</value>
        public bool FlipPage
        {
            get => HasTag("flip-page");
            set
            {
                if (value)
                    SetTag("flip-page");
                else
                    RemoveTag("flip-page");
            }
        }
    }
}
