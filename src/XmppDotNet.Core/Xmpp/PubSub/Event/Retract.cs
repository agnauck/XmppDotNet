using XmppDotNet.Attributes;
using XmppDotNet.Xml;

namespace XmppDotNet.Xmpp.PubSub.Event
{
    [XmppTag(Name = "retract", Namespace = Namespaces.PubsubEvent)]
    public class Retract : XmppXElement
    {
        #region << Constructors >>
    
        public Retract() : base(Namespaces.PubsubEvent, "retract")
        {
        }
        #endregion

        #region << Properties >>
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public string Id
        {
            get { return GetAttribute("id"); }
            set { SetAttribute("id", value); }
        }
        #endregion
    }
}
