using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Vcard
{
    
    public class VCardTest
    {
        [Fact]
        public void TestVcardIq()
        {
            var iq = XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.vcard_iq1.xml")).Cast<Iq>();
            var vcard = iq.Element<XmppDotNet.Xmpp.Vcard.Vcard>();
            Assert.True(vcard != null);
        }
    }
}
