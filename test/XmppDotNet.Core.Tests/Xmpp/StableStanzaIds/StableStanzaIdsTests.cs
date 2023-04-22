using XmppDotNet.Xml;
using Shouldly;
using XmppDotNet.Xmpp.StableStanzaIds;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.StableStanzaIds
{
    public class StableStanzaIdsTests
    {
        const string XML = @"<message xmlns='jabber:client'>
    <body>Typical body text</body>
    <stanza-id xmlns='urn:xmpp:sid:0'
             id='5f3dbc5e-e1d3-4077-a492-693f3769c7ad'
             by='room@muc.example.com'/>
    <origin-id xmlns='urn:xmpp:sid:0' id='de305d54-75b4-431b-adb2-eb6b9e546013'/>
    <referenced-stanza xmlns='urn:xmpp:sid:0' id='xep359-stanza-id' by='muc.example.org'/>
</message>";

        [Fact]
        public void TestParseStanzaIds()
        {
            var msg = XmppXElement.LoadXml(XML) as XmppDotNet.Xmpp.Client.Message;
            msg.StanzaId.ShouldNotBeNull();
            msg.StanzaId.Id.ShouldBe("5f3dbc5e-e1d3-4077-a492-693f3769c7ad");
            msg.StanzaId.By.ToString().ShouldBe("room@muc.example.com");
            
            msg.OriginId.ShouldNotBeNull();
            msg.OriginId.Id.ShouldBe("de305d54-75b4-431b-adb2-eb6b9e546013");
            
            msg.ReferencedStanzaId.ShouldNotBeNull();
            msg.ReferencedStanzaId.Id.ShouldBe("xep359-stanza-id");
            msg.ReferencedStanzaId.By.ToString().ShouldBe("muc.example.org");
        }
        
        [Fact]
        public void TestCreateStanzaIds()
        {
            var msg = new XmppDotNet.Xmpp.Client.Message
            {
                Body = "Typical body text",
                StanzaId = new StanzaId()
                {
                    Id = "5f3dbc5e-e1d3-4077-a492-693f3769c7ad",
                    By = "room@muc.example.com"
                },
                OriginId = new OriginId()
                {
                    Id = "de305d54-75b4-431b-adb2-eb6b9e546013"
                },
                ReferencedStanzaId = new ReferencedStanzaId()
                {
                   Id = "xep359-stanza-id",
                   By = "muc.example.org"
                }
            };
            
            msg.ShouldBe(XML);
        }
    }    
}
