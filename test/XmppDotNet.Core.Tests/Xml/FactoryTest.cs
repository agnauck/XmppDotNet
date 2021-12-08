using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xml
{
    public class FactoryTest
    {
        [Fact]
        public void ShouldReturnXName()
        {
            Factory.GetXName<Message>().ShouldBe("{jabber:client}message");
        }
    }
}
