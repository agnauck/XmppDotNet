using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.StreamManagement.Ack
{
    [XmppTag(Name = "a", Namespace = Namespaces.FeatureStreamManagement)]
    public class Answer : XmppXElement
    {
        public Answer() : base(Namespaces.FeatureStreamManagement, "a")
        {
        }

        /// <summary>
        /// Identifies the last handled stanza (i.e., the last stanza that the receiver will acknowledge as having received).
        /// </summary>
        public long LastHandledStanza
        {
            get { return GetAttributeLong("h"); }
            set { SetAttribute("h", value); }
        }
    }
}
