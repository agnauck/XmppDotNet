using System.Collections.Generic;

namespace XmppDotNet.Xmpp.Rpc
{
    public class Parameters : List<object>
    {
        public Parameters() {}
        public Parameters(IEnumerable<object> collection) : base(collection) {}
        public Parameters(int capacity) : base(capacity) {}
    }
}
