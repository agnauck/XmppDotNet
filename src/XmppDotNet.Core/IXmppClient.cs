namespace XmppDotNet
{
    public interface IXmppClient : IClientIqSender, IStanzaSender
    {
        Jid Jid { get; set; }
        string Password { get; set; }
        string Resource { get; set; }
    }
}
