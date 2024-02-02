using System.Linq;
using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using XmppDotNet.Xmpp.Sasl2;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl2;

public class AuthenticationTest
{
    [Fact]
    public void XmlShouldBeOfTypeAuthentication()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl2.authentication1.xml"))
            .ShouldBeOfType<Authentication>();
    }
    
    [Fact]
    public void TestAuthenticationMechanisms()
    {
        var auth 
            = XmppXElement
                .LoadXml(Resource.Get("Xmpp.Sasl2.authentication1.xml"))
                .Cast<Authentication>();
        
        auth.GetMechanisms().Count().ShouldBe(2);
        auth.SupportsMechanism(SaslMechanism.ScramSha1).ShouldBeTrue();
        auth.SupportsMechanism(SaslMechanism.ScramSha1Plus).ShouldBeTrue();
        auth.SupportsMechanism(SaslMechanism.Plain).ShouldBeFalse();
    }
}
