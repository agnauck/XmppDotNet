namespace XmppDotNet.Tests.Xmpp.Sasl
{
    using XmppDotNet.Sasl.WebexToken;
    using XmppDotNet.Xml;
    using XmppDotNet.Xmpp.Sasl;
    using Moq;
    using Shouldly;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    public class WebexTokenProcessorTest
    {
        [Fact]
        public async Task Test_Authentication_Message()
        {
            var expectedXml = "<auth mechanism='WEBEX-TOKEN' xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>Zm9v</auth>";

            var webexTokeSasl = new WebexTokenProcessor("foo");

            Mock<IXmppClient> mockXmppClient = new Mock<IXmppClient>();
            mockXmppClient
                .Setup(s => s.SendAsync<Success, Failure>(It.IsAny<XmppXElement>(), It.IsAny<CancellationToken>()))
               .Callback<XmppXElement, CancellationToken>((el, ct) =>
                {
                    el.ShouldBe(expectedXml);
                })
               .Returns(Task.FromResult<XmppXElement>(new Success()));

            var res = await webexTokeSasl.AuthenticateClientAsync(mockXmppClient.Object, CancellationToken.None);
        }
    }
}
