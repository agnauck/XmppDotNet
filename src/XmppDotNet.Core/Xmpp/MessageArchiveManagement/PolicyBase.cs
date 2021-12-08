using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.MessageArchiveManagement
{
    using System.Collections.Generic;
    using Xml;
    
    public abstract class PolicyBase : XmppXElement
    {
        protected PolicyBase(string tagName)
            : base(Namespaces.MessageArchiveManagement, tagName)
        {
        }

        /// <summary>
        /// Adds an Item.
        /// </summary>
        /// <param name="jid">The item.</param>
        /// <returns></returns>
        public Jid AddJid(XmppDotNet.Jid jid)
        {
            var j = new Jid(jid);
            Add(j);

            return j;
        }

        /// <summary>
        /// Adds an Item.
        /// </summary>
        /// <param name="jid">The item.</param>
        public void AddJid(Jid jid)
        {
            Add(jid);
        }

        /// <summary>
        /// Gets the jids.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Jid> GetJids()
        {
            return Elements<Jid>();
        }
    }
}