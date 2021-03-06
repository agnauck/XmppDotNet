using System.Text;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl
{
    public class ResponseTest
    {
        [Fact]
        public void ShouldBeOfTypeResponse()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl.response1.xml")).ShouldBeOfType<Response>();
        }

        [Fact]
        public void TestResponse()
        {
            var resp = XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl.response1.xml")).Cast<Response>();

            byte[] bval = resp.Bytes;
            string sval = Encoding.ASCII.GetString(bval);
            Assert.Equal("dummy value", sval);
        }
    }
}
