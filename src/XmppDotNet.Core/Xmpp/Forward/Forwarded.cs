using XmppDotNet.Attributes;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;

namespace XmppDotNet.Xmpp.Forward
{
    [XmppTag(Name = "forwarded", Namespace = Namespaces.Forward)]
    public class Forwarded : XmppXElement
    {
        public Forwarded() : base(Namespaces.Forward, "forwarded") { }

        public Message Message
        {
            get => Element<Message>();
            set => Replace(value);
        }
        
        /// <summary>
        /// Gets or sets the <see cref="Delay"/>.
        /// </summary>
        /// <value>The delay.</value>
        public Delay.Delay Delay
        {
            get => Element<Delay.Delay>();
            set => Replace(value);
        }
    }
}
