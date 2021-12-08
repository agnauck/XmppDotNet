using Xunit;

using XmppDotNet.Xml;
using Shouldly;
using XmppDotNet.Xmpp.Avatar;
using System.Text;

namespace XmppDotNet.Tests.Xmpp.Avatar
{
    public class DataTests
    {
        [Fact]
        public void TestFactory()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Avatar.data.xml"))
                .ShouldBeOfType<Data>();
        }

        [Fact]
        public void TestReadAttributes()
        {
            var data = XmppXElement.LoadXml(Resource.Get("Xmpp.Avatar.data.xml")).Cast<Data>();

            data.Bytes.ShouldBe(Encoding.UTF8.GetBytes("Hello World"));
            
        }        
    }
}
