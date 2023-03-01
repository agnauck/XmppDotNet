using XmppDotNet.Xml;
using XmppDotNet.Xmpp.MessageCarbons;
using Xunit;

using Shouldly;
using XmppDotNet.Xmpp.Client;

namespace XmppDotNet.Tests.Xmpp.MessageCarbons
{
    
    public class MessageCarbonTest
    {
        [Fact]
        public void ShouldBeOfTypeForwarded()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.MessageCarbons.forwarded1.xml")).ShouldBeOfType<Forwarded>();
        }

        [Fact]
        public void MessageShouldComtainForwarded()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.MessageCarbons.message_carbons1.xml"));

            msg.FirstXmppXElement.Cast<ForwardContainer>()
                .Forwarded.ShouldNotBeNull();
        }

        [Fact]
        public void ShouldBeSentCarbonMessage()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.MessageCarbons.message_carbons1.xml")).Cast<Message>();
            msg.IsSentCarbon.ShouldBeTrue();
            msg.SentCarbon.ShouldNotBeNull();
            msg.ReceivedCarbon.ShouldBeNull();

            msg.SentCarbon.Forwarded.Message.ShouldNotBeNull();
            msg.SentCarbon.Forwarded.Message.Body.ShouldBe("blarg");
        }

        [Fact]
        public void ShouldBeReceivedCarbonMessage()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.MessageCarbons.message_carbons2.xml")).Cast<Message>();
            msg.IsReceivedCarbon.ShouldBeTrue();
            msg.ReceivedCarbon.ShouldNotBeNull();
            msg.SentCarbon.ShouldBeNull();

            msg.ReceivedCarbon.Forwarded.Message.ShouldNotBeNull();
            msg.ReceivedCarbon.Forwarded.Message.Body.ShouldBe("blarg");
        }
    }
}
