using System.Text;
using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Sasl
{
    
    public class AuthTest
    {
        [Fact]
        public void ShouldBeOfTypeAuth()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl.auth1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Sasl.Auth>();
        }

        [Fact]
        public void TestAuth()
        {
            var resp = XmppXElement.LoadXml(Resource.Get("Xmpp.Sasl.auth1.xml")).Cast<XmppDotNet.Xmpp.Sasl.Auth>();

            byte[] bval = resp.Bytes;
            string sval = Encoding.ASCII.GetString(bval);
            Assert.Equal("dummy value", sval);
        }

        [Fact]
        public void TestBuildAuth()
        {
            new XmppDotNet.Xmpp.Sasl.Auth { Bytes = Encoding.ASCII.GetBytes("dummy value") }
                .ShouldBe(Resource.Get("Xmpp.Sasl.auth1.xml"));
        }
    }
}
