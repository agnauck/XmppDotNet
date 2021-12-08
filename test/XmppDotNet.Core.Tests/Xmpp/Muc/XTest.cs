using XmppDotNet.Xmpp.Client;
using System.Linq;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Muc;
using X = XmppDotNet.Xmpp.Muc.X;

using Xunit;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Muc
{
    
    public class XTest
    {
        [Fact]
        public void ShoudBeOfTypeX()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.x1.xml")).ShouldBeOfType<X>();
        }

        [Fact]
        public void TestX()
        {
            var x = XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.x1.xml")).Cast<X>();
            Assert.Equal("secret", x.Password);

            x = XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.x2.xml")).Cast<X>();
            Assert.Equal(20, x.History.MaxStanzas);
        }


        [Fact]
        public void TestBuildX()
        {
            var x = new X(new History(20));
            x.ShouldBe(Resource.Get("Xmpp.Muc.x2.xml"));

            x = new X("secret");
            x.ShouldBe(Resource.Get("Xmpp.Muc.x1.xml"));
        }
        

        [Fact]
        public void TestMucInvite()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.message1.xml")).Cast<Message>();
            var xMuc = msg.Element<XmppDotNet.Xmpp.Muc.User.X>();
            Assert.Equal("cauldronburn", xMuc.Password);

            var invite = xMuc.GetInvites().First();
            Assert.Equal("FOO", invite.Reason);
        }
    }
}
