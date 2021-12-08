using XmppDotNet.Xmpp.Google.Mobile;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Google.GCM
{
    
    public class GcmTest
    {
        [Fact]
        public void BuildGcmMessage()
        {
            var msg = new XmppDotNet.Xmpp.Client.Message {Id = "foo"};
            msg.Add(new Gcm {Value = "{'to':'REGISTRATION_ID'}" });

            msg.ShouldBe(Resource.Get("Xmpp.Google.GCM.message1.xml"));
        }
    }
}
