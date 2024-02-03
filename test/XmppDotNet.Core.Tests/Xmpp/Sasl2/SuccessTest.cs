using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl2;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl2;

public class SuccessTest
{
    [Fact]
    public void XmlShouldBeOfTypeFailure()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl2.success.xml"))
            .ShouldBeOfType<Success>();
    }
    
    [Fact]
    public void GetAuthId()
    {
        var success
            = XmppXElement
                .LoadXml(Resource.Get("Xmpp.Sasl2.success.xml"))
                .Cast<Success>();

        success.AuthorizationIdentifier.ToString().ShouldBe("juliet@montague.example/Balcony/a987dsh9a87sdh");
    }
    
    [Fact]
    public void BuildFailureStanza()
    {
        var success = new Success()
        {
            AuthorizationIdentifier = "juliet@montague.example/Balcony/a987dsh9a87sdh"
        };
        
        success.ShouldBe(Resource.Get("Xmpp.Sasl2.success.xml"));
    }
    
    [Fact]
    public void TestSuccessProperties()
    {
        var success
            = XmppXElement
                .LoadXml(Resource.Get("Xmpp.Sasl2.success1.xml"))
                .Cast<Success>();
        
        success.Bound.ShouldNotBeNull();
        success.Bound.MetaData.ShouldNotBeNull();
        
        success.Bound.MetaData.Start.Id.ShouldBe("YWxwaGEg");
        success.Bound.MetaData.End.Id.ShouldBe("b21lZ2Eg");
    }
}
