using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Client
{
    public class TimeIqTest
    {
        [Fact]
        public void BuildTimeIq()
        {
            string expectedXml = Resource.Get("Xmpp.Client.timeiq.xml");
            new TimeIq
            {
                Type = XmppDotNet.Xmpp.IqType.Get,
                To = "juliet@capulet.com/balcony",
                Id = "time_1"
            }
            .ShouldBe(expectedXml);
        }
    }
}
