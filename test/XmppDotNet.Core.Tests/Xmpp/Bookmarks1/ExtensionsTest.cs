using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Bookmarks1
{
    public class ExtensionsTest
    {
        [Fact]
        public void XmlShouldBeOfTypeExtensions()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks1.extensions.xml"))
               .ShouldBeOfType<XmppDotNet.Xmpp.Bookmarks1.Extensions>();
        }
    }
}
