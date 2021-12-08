using XmppDotNet.Xmpp;
using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.PubSub.Owner
{
    public class DeleteTest
    {
        [Fact]
        public void BuildPubsibDeleteIq()
        {

            var pIq = new PubSubOwnerIq
            {
                From = "hamlet@denmark.lit/elsinore",
                To = "pubsub.shakespeare.lit",
                Id = "delete1",
                Type = IqType.Set,
                PubSub = { Delete = new XmppDotNet.Xmpp.PubSub.Owner.Delete { Node = "princely_musings" } }
            };

            pIq.ShouldBe(Resource.Get("Xmpp.PubSub.Owner.pubsub_delete_iq1.xml"));
        }
    }
}
