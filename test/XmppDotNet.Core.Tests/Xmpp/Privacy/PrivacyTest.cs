using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Privacy
{
    public class PrivacyTest
    {
        [Fact]
        public void ShoudBeOfTypePrivacy()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Privacy.privacy_query1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Privacy.Privacy>();
        }

        [Fact]
        public void TestPrivacy()
        {
            var priv = XmppXElement.LoadXml(Resource.Get("Xmpp.Privacy.privacy_query1.xml")).Cast<XmppDotNet.Xmpp.Privacy.Privacy>();
            Assert.Equal("public", priv.Default.Name);
            Assert.Equal("private", priv.Active.Name);
        }
    }
}
