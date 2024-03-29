﻿namespace XmppDotNet.Tests.Xmpp.Sasl
{
    using XmppDotNet.Xml;
    using Xunit;
    using Moq;
    using XmppDotNet.Xmpp.Sasl;
    using System.Threading.Tasks;
    using System.Threading;
    using XmppDotNet.Sasl.CiscoVtgToken;

    public class CiscoVtgTokenProcessorTest
    {
        [Fact]
        public async Task Test_Authentication_Message()
        {
            var expectedXml = "<auth mechanism='CISCO-VTG-TOKEN' xmlns='urn:ietf:params:xml:ns:xmpp-sasl'>dXNlcmlkPXVzZXJAc2VydmVyLmNvbQB0b2tlbj1mb28=</auth>";

            var webexTokeSasl = new CiscoVtgTokenProcessor("foo");
            var mockXmppClient = new Mock<IXmppClient>();
            mockXmppClient.SetupGet(client => client.Jid).Returns(new Jid("user@server.com"));

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
