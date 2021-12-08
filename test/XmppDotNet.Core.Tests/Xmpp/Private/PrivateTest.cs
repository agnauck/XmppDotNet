using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Private
{
    
    public class PrivateTest
    {
        [Fact]
        public void ShoudBeOfTypePrivate()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Private.private1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Private.Private>();
        }
    }
}
