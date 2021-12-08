namespace XmppDotNet.Extensions.Tests.Client
{
    using System.Threading.Tasks;
    using Xunit;
    using XmppDotNet.Extensions.Client.Subscription;
    using Moq;
    using XmppDotNet.Xml;
    using XmppDotNet.Xmpp.Client;
    using Shouldly;

    public class SubscriptionExtensionsTests
    {
        [Fact]
        public async Task ApproveSubscriptionRequestTest()
        {
            var mock = new Mock<IStanzaSender>();

            XmppXElement result = null;
            mock.Setup(s => s.SendAsync(It.IsAny<XmppXElement>()))
                .Callback<XmppXElement>((el) => result = el)
                .Returns(Task.CompletedTask);

            string expectedResult = "<presence xmlns='jabber:client' to='user@server.com' type='subscribed'/>";

            await mock.Object.ApproveSubscriptionRequestAsync(new Jid("user@server.com"));

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public async Task DenySubscriptionRequestTest()
        {
            var mock = new Mock<IStanzaSender>();

            XmppXElement result = null;
            mock.Setup(s => s.SendAsync(It.IsAny<XmppXElement>()))
                .Callback<XmppXElement>((el) => result = el)
                .Returns(Task.CompletedTask);

            string expectedResult = "<presence xmlns='jabber:client' to='user@server.com' type='unsubscribed'/>";

            await mock.Object.DenySubscriptionRequestAsync(new Jid("user@server.com"));

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public async Task CancelSubscriptionRequestTest()
        {
            var mock = new Mock<IStanzaSender>();

            XmppXElement result = null;
            mock.Setup(s => s.SendAsync(It.IsAny<XmppXElement>()))
                .Callback<XmppXElement>((el) => result = el)
                .Returns(Task.CompletedTask);

            string expectedResult = "<presence xmlns='jabber:client' to='user@server.com' type='unsubscribed'/>";

            await mock.Object.CancelSubscriptionAsync(new Jid("user@server.com"));

            result.ShouldBe(expectedResult);
        }

        [Fact]
        public async Task SubscribeTest()
        {
            var mock = new Mock<IStanzaSender>();

            XmppXElement result = null;
            mock.Setup(s => s.SendAsync(It.IsAny<XmppXElement>()))
                .Callback<XmppXElement>((el) => result = el)
                .Returns(Task.CompletedTask);

            string expectedResult = "<presence xmlns='jabber:client' to='user@server.com' type='subscribe'/>";

            await mock.Object.SubscribeAsync(new Jid("user@server.com"));

            result.ShouldBe(expectedResult);
        }
    }
}
