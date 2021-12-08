using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Privacy
{
    /// <summary>
    /// privacy list action
    /// </summary>
    public enum Action
    {
        /// <summary>
        /// 
        /// </summary>
        [Name("allow")]
        Allow,
        
        /// <summary>
        /// 
        /// </summary>
        [Name("deny")]
        Deny
    }
}
