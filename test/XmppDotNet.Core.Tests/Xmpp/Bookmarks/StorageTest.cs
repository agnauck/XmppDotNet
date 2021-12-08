using System.Linq;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Bookmarks;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Bookmarks
{
    public class StorageTest
    {
        [Fact]
        public void XmlShouldBeOfTypeStorage()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks.storage1.xml"))
                .ShouldBeOfType<Storage>();
        }

        [Fact]
        public void TestConferenceCount()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bookmarks.storage1.xml"))
                .Cast<Storage>()
                .GetConferences()
                .Count()
                .ShouldBe(4);
        }
    }
}
