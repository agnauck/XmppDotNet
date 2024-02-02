using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using Xunit;
using Failure = XmppDotNet.Xmpp.Sasl2.Failure;

namespace XmppDotNet.Tests.Xmpp.Sasl2;

public class FailureTest
{
    [Fact]
    public void XmlShouldBeOfTypeFailure()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl2.failure.xml"))
            .ShouldBeOfType<Failure>();
    }
    
    [Fact]
    public void TestFailureProperties()
    {
        var failure 
            = XmppXElement
                .LoadXml(Resource.Get("Xmpp.Sasl2.failure.xml"))
                .Cast<Failure>();
        
        failure.Text.ShouldBe("This is a terrible example.");
        failure.Condition.ShouldBe(FailureCondition.Aborted);
    }
    
    [Fact]
    public void BuildFailureStanza()
    {
        var failure = new Failure()
        {
            Text = "This is a terrible example.",
            Condition = FailureCondition.Aborted
        };
        
        failure.ShouldBe(Resource.Get("Xmpp.Sasl2.failure.xml"));
    }

}