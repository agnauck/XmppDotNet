using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Rpc
{
    [XmppTag(Name = "methodResponse", Namespace = Namespaces.IqRpc)]
    public class MethodResponse : XmlRpcBase
    {
        public MethodResponse()
            : base("methodResponse")
        {
        }

        /// <summary>
        /// Is this response and error?
        /// </summary>
        public bool IsError
        {
            get { return HasTag<Fault>(); }
        }
    }
}
