namespace XmppDotNet.Transport
{
    using XmppDotNet;

    public class TransportState : DistinctBehaviorSubject<State>
    {
        public TransportState() : base(State.Disconnected)
        {
        }
    }
}
