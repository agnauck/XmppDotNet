using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Roster
{
    public enum Ask
    {
        None = -1,

        [Name("subscribe")]
        Subscribe,
        
        [Name("unsubscribe")]
        Unsubscribe
    }
}
