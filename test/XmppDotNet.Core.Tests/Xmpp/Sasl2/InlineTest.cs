using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl2;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl2;

public class InlineTest
{
    [Fact]
    public void XmlShouldBeOfTypeInline()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl2.inline1.xml"))
            .ShouldBeOfType<Inline>();
    }
}
