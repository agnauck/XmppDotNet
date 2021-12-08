using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Base
{
    public class XmppXElementWithJidAttributeTest
    {
        [Fact]
        public void JidShouldNotBeNull()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Base.mucuser2.xml"))
                .Cast<XmppDotNet.Xmpp.Muc.User.X>()
                .Item.Jid.ShouldNotBeNull();
        }

        [Fact]
        public void TestJid()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Base.mucuser2.xml"))
                .Cast<XmppDotNet.Xmpp.Muc.User.X>()
                .Item.Jid.ToString().ShouldBe("server");
        }

        [Fact]
        public void JidShouldBeNull()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Base.mucuser1.xml"))
                .Cast<XmppDotNet.Xmpp.Muc.User.X>()
                .Item.Jid.ShouldBeNull();
            

        }
    }
}
