using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.PubSub
{
    public class PubSubIqTest
    {
        [Fact]
        public void TestBuildPubSubIq1()
        {
            PubSubIq pIq = new PubSubIq
            {
                Type = XmppDotNet.Xmpp.IqType.Result,
                From = "pubsub.shakespeare.lit",
                To = "hamlet@denmark.lit/elsinore",
                Id = "create2",
                PubSub = {Create = new XmppDotNet.Xmpp.PubSub.Create {Node = "25e3d37dabbab9541f7523321421edc5bfeb2dae"}}
            };


            pIq.ShouldBe(Resource.Get("Xmpp.PubSub.publish_iq1.xml"));
        }

        [Fact]
        public void TestBuildPubSubIq2()
        {
            var pIq = new PubSubIq
            {
                Type = XmppDotNet.Xmpp.IqType.Set,
                From = "hamlet@denmark.lit/elsinore",
                To = "pubsub.shakespeare.lit",
                Id = "create2"

            };

            pIq.PubSub.Create       = new XmppDotNet.Xmpp.PubSub.Create();
            pIq.PubSub.Configure    = new XmppDotNet.Xmpp.PubSub.Configure();
            
            pIq.ShouldBe(Resource.Get("Xmpp.PubSub.publish_iq2.xml"));
        }
    }
}
