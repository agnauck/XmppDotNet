using XmppDotNet.Xmpp.Forward;

namespace XmppDotNet.Xmpp.MessageCarbons
{
    public abstract class ForwardContainer : CarbonBase
    {
        protected ForwardContainer(string tagname) : base(tagname) { }
        
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
