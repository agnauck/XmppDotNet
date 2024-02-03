using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using XmppDotNet.Xmpp.Sasl2;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl2;

public class AuthenticateTest
{
    [Fact]
    public void XmlShouldBeOfTypeAuthenticate()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl2.authenticate1.xml"))
            .ShouldBeOfType<Authenticate>();
    }

    [Fact]
    public void TestAuthenticateProperties()
    {
        var auth 
            = XmppXElement
                .LoadXml(Resource.Get("Xmpp.Sasl2.authenticate2.xml"))
                .Cast<Authenticate>();
        
        auth.SaslMechanism.ShouldBe(SaslMechanism.ScramSha1);
        auth.InitialResponse.Value.ShouldBe("[base64 encoded SASL data]");
    }
}
