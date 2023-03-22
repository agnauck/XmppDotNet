using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Bookmarks1;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Bookmarks1
{
    public class ConferenceTest
    {
        [Fact]
        public void XmlShouldBeOfTypeConference()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.conference1.xml"))
               .ShouldBeOfType<Conference>();

            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.conference2.xml"))
               .ShouldBeOfType<Conference>();
        }

        [Fact]
        public void TestConferenceName()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.conference1.xml"))
                .Cast<Conference>()
                .Name.ShouldBe("Council of Oberon");
        }

        [Fact]
        public void TestConferenceAutojoin()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.conference1.xml"))
                .Cast<Conference>()
                .AutoJoin.ShouldBeTrue();
        }

        [Fact]
        public void TestConferenceExtensions()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.conference1.xml"))
                .Cast<Conference>()
                .Extensions.ShouldBeNull();
        }

        [Fact]
        public void TestConferenceItem()
        {
            var item = XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.item.xml"))
                .Cast<XmppDotNet.Xmpp.PubSub.Item>();

            item.Id.ShouldBe("orchard@conference.shakespeare.lit");

            var conf = item.Element<Conference>();
            conf.Name.ShouldBe("The Orcard");
            conf.Nickname.ShouldBe("JC");
            conf.AutoJoin.ShouldBeTrue();
            conf.Extensions.ShouldNotBeNull();
            conf.Extensions.GetTag("http://myclient.example/bookmark/state", "state").ShouldNotBeNull();
        }

        [Fact]
        public void BuildConference()
        {
            var expectedXml = Resource.Get("Xmpp.Bookmarks1.conference1.xml");
            new Conference {
                Name = "Council of Oberon",
                AutoJoin = true,               
                Nickname = "JC",
            }
            .ShouldBe(expectedXml);
        }
    }
}
