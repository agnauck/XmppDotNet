using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Forwarded;

public class ForwardedTest
{
    [Fact]
    public void TestForwardedWithDelay()
    {
        string XML = @"<message id='aeb213' to='juliet@capulet.lit/chamber' xmlns='jabber:client'>
  <result xmlns='urn:xmpp:mam:2' queryid='f27' id='28482-98726-73623'>
    <forwarded xmlns='urn:xmpp:forward:0'>
      <delay xmlns='urn:xmpp:delay' stamp='2010-07-10T23:08:25Z'/>
      <message xmlns='jabber:client'
        to='juliet@capulet.lit/balcony'
        from='romeo@montague.lit/orchard'
        type='chat'>
        <body>Call me but love, and I'll be new baptized; Henceforth I never will be Romeo.</body>
      </message>
    </forwarded>
  </result>
</message>";

        var msg = XmppXElement.LoadXml(XML).Cast<Message>();
        var fwd = msg.MamResult.Forwarded;
        fwd.Delay.ShouldNotBeNull();
        fwd.Delay.Stamp.Year.ShouldBe(2010);
    }
}
