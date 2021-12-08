using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Muc.User
{
    public class GTalkTest
    {
        [Fact]
        public void TestGtalkPresence()
        {
            var pres = XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.User.presence_gtalk1.xml")).Cast<Presence>();

            Assert.True(pres.Show == XmppDotNet.Xmpp.Show.DoNotDisturb);
            Assert.Equal("Alex", pres.Nick.Value);
            
            var mucUser = pres.MucUser;
            var item = mucUser.Item;
            Assert.True(item.Role == XmppDotNet.Xmpp.Muc.Role.Participant);
            Assert.True(item.Affiliation == XmppDotNet.Xmpp.Muc.Affiliation.Member);
            Assert.True(item.Jid == "XXX@gmail.com/gmail.59477926");
        }
    }
}
