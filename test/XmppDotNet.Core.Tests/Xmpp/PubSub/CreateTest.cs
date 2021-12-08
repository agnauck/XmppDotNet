using XmppDotNet.Xml;
using XmppDotNet.Xmpp.PubSub;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.PubSub
{
    public class CreateTest
    {
        [Fact]
        public void ShoudBeOfTypeConfigure()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.PubSub.Owner.create1.xml")).ShouldBeOfType<Create>();
        }

        [Fact]
        public void TestCreate()
        {
            var c = XmppXElement.LoadXml(Resource.Get("Xmpp.PubSub.Owner.create1.xml")).Cast<Create>(); ;
            Assert.Equal("generic/pgm-mp3-player", c.Node);
        }

        [Fact]
        public void TestBuildCreate()
        {
            var create = new Create { Node = "generic/pgm-mp3-player" };
            create.ShouldBe(Resource.Get("Xmpp.PubSub.Owner.create1.xml"));
        }
    }
}
