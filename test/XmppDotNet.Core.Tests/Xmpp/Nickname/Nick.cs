using Xunit;

using XmppDotNet.Xml;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Nickname
{
    public class Nick
    {
        [Fact]
        public void ShoudBeOfTypeX()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Nickname.nick1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Nickname.Nick>();
        }

        [Fact]
        public void TestNick()
        {
            XmppDotNet.Xmpp.Nickname.Nick nick1 = XmppXElement.LoadXml(Resource.Get("Xmpp.Nickname.nick1.xml")).Cast<XmppDotNet.Xmpp.Nickname.Nick>();
            Assert.True(nick1 == "Ishmael");
        }

        [Fact]
        public void TestBuildNick()
        {
            XmppDotNet.Xmpp.Nickname.Nick nick1 = "Alex";
            Assert.Equal("Alex", nick1.Value);
            Assert.True(nick1 == "Alex");

            XmppDotNet.Xmpp.Nickname.Nick nick2 = "Ishmael";
            Assert.Equal("Ishmael", nick2.Value);
            Assert.True(nick2 == "Ishmael");

            XmppDotNet.Xmpp.Nickname.Nick nick3 = new XmppDotNet.Xmpp.Nickname.Nick("Alex");
            Assert.Equal("Alex", nick3.Value);
            Assert.True(nick3 == "Alex");
        }

        [Fact]
        public void TestNickInPresence()
        {
            XmppDotNet.Xmpp.Client.Presence pres = XmppXElement.LoadXml(Resource.Get("Xmpp.Nickname.presence1.xml")).Cast<XmppDotNet.Xmpp.Client.Presence>();
            XmppDotNet.Xmpp.Nickname.Nick nick1 = pres.Nick;
            Assert.True(nick1 == "Ishmael");
        }

        [Fact]
        public void TestBuildPresenceWithNick()
        {
            XmppDotNet.Xmpp.Client.Presence pres = new XmppDotNet.Xmpp.Client.Presence { Nick = "Alex" };

            Assert.Equal("Alex", pres.Nick.Value);

            pres.Nick.Value = "Ishmael";
            Assert.Equal("Ishmael", pres.Nick.Value);
        }
    }
}
