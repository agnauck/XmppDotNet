using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Auth
{    
    public class AuthTest
    {
        [Fact]
        public void XmlShoudbeOfTypeAuth()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Auth.query.xml"))
                .ShouldBeOfType<XmppDotNet.Xmpp.Auth.Auth>();
        }

        [Fact]
        public void TestUsername()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Auth.query.xml"))
                .Cast<XmppDotNet.Xmpp.Auth.Auth>()
                .Username.ShouldBe("gnauck");
        }
        
        [Fact]
        public void TestHastDigestTag()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Auth.query.xml"))
                .Cast<XmppDotNet.Xmpp.Auth.Auth>()
                .HasTag("digest");

            XmppXElement.LoadXml(Resource.Get("Xmpp.Auth.query.xml"))
                .Cast<XmppDotNet.Xmpp.Auth.Auth>()
                .Digest.ShouldNotBeNull();
        }
    }
}
