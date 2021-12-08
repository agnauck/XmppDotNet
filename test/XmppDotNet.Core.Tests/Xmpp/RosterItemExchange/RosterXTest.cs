using System.Linq;
using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.RosterItemExchange
{
    public class RosterXTest
    {
        [Fact]
        public void ShouldBeOfTypeExchange()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.x1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.Exchange>();
            XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.x2.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.Exchange>();
        }

        [Fact]
        public void ShouldBeOfTypeRosterExchangeItem()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.item1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.RosterExchangeItem>();
        }

        [Fact]
        public void TestRosterExchangeItem()
        {
            var item = XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.item1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.RosterExchangeItem>();
            Assert.True(item.Action == XmppDotNet.Xmpp.RosterItemExchange.Action.Add);

            var item3 = XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.item2.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.RosterExchangeItem>();
            Assert.True(item3.Action == XmppDotNet.Xmpp.RosterItemExchange.Action.Add);
            
            var item4 = XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.item3.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.RosterExchangeItem>();
            Assert.True(item4.Action == XmppDotNet.Xmpp.RosterItemExchange.Action.Modify);
        }

        [Fact]
        public void TestRosterItemExchangeWithItems()
        {
            var rosterx = XmppXElement.LoadXml(Resource.Get("Xmpp.RosterItemExchange.x2.xml")).ShouldBeOfType<XmppDotNet.Xmpp.RosterItemExchange.Exchange>();
            var items = rosterx.GetRosterExchangeItems();

            Assert.Equal(2, items.Count());
        }
    }
}
