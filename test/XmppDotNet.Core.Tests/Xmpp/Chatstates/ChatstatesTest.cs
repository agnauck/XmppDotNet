using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Xunit;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Chatstates
{
    public class ChatstatesTest
    {
        [Fact]
        public void TestMessageStates()
        {
            var expectedXml = XmppXElement.LoadXml(Resource.Get("Xmpp.Chatstates.message2.xml")).Cast<Message>();
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.Chatstates.message1.xml")).Cast<Message>();

            msg.Chatstate.ShouldBe(XmppDotNet.Xmpp.Chatstates.Chatstate.Active);
            msg.Chatstate.ShouldNotBe(XmppDotNet.Xmpp.Chatstates.Chatstate.Composing);
            msg.Chatstate.ShouldNotBe(XmppDotNet.Xmpp.Chatstates.Chatstate.Gone);

            msg.Chatstate = XmppDotNet.Xmpp.Chatstates.Chatstate.None;
            msg.ShouldBe(expectedXml);
        }

        [Fact]
        public void TestMessageStates2()
        {
            var expectedXml = XmppXElement.LoadXml(Resource.Get("Xmpp.Chatstates.message1.xml")).Cast<Message>();
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.Chatstates.message2.xml")).Cast<Message>();
            msg.Chatstate.ShouldBe(XmppDotNet.Xmpp.Chatstates.Chatstate.None);
            msg.Chatstate = XmppDotNet.Xmpp.Chatstates.Chatstate.Active;
            msg.ShouldBe(expectedXml);
        }

        [Fact]
        public void BuildChatStateMessage()
        {
            var expectedXml = XmppXElement.LoadXml(Resource.Get("Xmpp.Chatstates.message3.xml")).Cast<Message>();
            new Message
                {
                    Type = XmppDotNet.Xmpp.MessageType.Chat,
                    Chatstate = XmppDotNet.Xmpp.Chatstates.Chatstate.Gone
                }
                .ShouldBe(expectedXml);
        }
    }
}
