using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Muc;
using XmppDotNet.Xmpp.Client;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Muc
{
    public class OccupantIdTests
    {
        [Fact]
        public void TestOccupantIdInMessage()
        {
            const string XML = @"<message
                from='coven@chat.shakespeare.lit/thirdwitch'
                id='hysf1v37'
                xmlns='jabber:client'
                to='crone1@shakespeare.lit/desktop'
                type='groupchat'>
              <body>Harpier cries: 'tis time, 'tis time.</body>
              <occupant-id xmlns='urn:xmpp:occupant-id:0' id='dd72603deec90a38ba552f7c68cbcc61bca202cd' />
            </message>";

            var msg = XmppXElement.LoadXml(XML).Cast<Message>();
            msg.OccupantId.Id.ShouldBe("dd72603deec90a38ba552f7c68cbcc61bca202cd");
        }

        [Fact]
        public void TestOccupantIdInPresence()
        {
            const string XML = @"<presence
                xmlns='jabber:client'
                from='coven@chat.shakespeare.lit/thirdwitch'
                id='27C55F89-1C6A-459A-9EB5-77690145D624'
                to='crone1@shakespeare.lit/desktop'>
              <x xmlns='http://jabber.org/protocol/muc#user' />
              <occupant-id xmlns='urn:xmpp:occupant-id:0' id='dd72603deec90a38ba552f7c68cbcc61bca202cd' />
            </presence>";

            var pres = XmppXElement.LoadXml(XML).Cast<Presence>();
            pres.OccupantId.Id.ShouldBe("dd72603deec90a38ba552f7c68cbcc61bca202cd");
        }

        [Fact]
        public void BuildMessageWithOccupantId()
        {
            const string XML = @"<message xmlns='jabber:client'>
                    <occupant-id xmlns='urn:xmpp:occupant-id:0' id='some-id' />
                </message>";

            var msg = new Message
            {
                OccupantId = new OccupantId()
                {
                    Id = "some-id"
                }
            };

            msg.ShouldBe(XML);
        }

        [Fact]
        public void BuildPresenceWithOccupantId()
        {
            const string XML = @"<presence xmlns='jabber:client'>
                    <occupant-id xmlns='urn:xmpp:occupant-id:0' id='some-id' />
                </presence>";

            var pres = new Presence
            {
                OccupantId = new OccupantId()
                {
                    Id = "some-id"
                }
            };

            pres.ShouldBe(XML);
        }
    }
}
