using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using Shouldly;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace XmppDotNet.Tests.Xml
{
    public class XmppXElementTests
    {
        [Fact]
        public void TestLoadXmlFromString()
        {
            string xml1 = "<a><b>foo</b></a>";
            var elA = XmppXElement.LoadXml(xml1);
            elA.ToString(false).ShouldBe(xml1);
        }

        [Fact]
        public void XmlShouldContainOneCDataElement()
        {
            var el = XmppXElement.LoadXml(Resource.Get("Xml.cdata1.xml"));

            var xml = el.ToString(false);
            Regex.Matches(xml, "CDATA").Count.ShouldBe(1);
        }

        [Fact]
        public void DescendantsTest()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xml.message.xml")).Cast<Message>();
            var elements = msg.Descendants<XmppDotNet.Xmpp.XData.Data>();

            elements.ShouldNotBeNull();
            elements.Count().ShouldBe(1);

            var firstResult = elements.First();
            firstResult.ShouldBeOfType<XmppDotNet.Xmpp.XData.Data>();

            var elements2 = msg.Descendants<XmppDotNet.Xmpp.XData.Field>();
            elements2.ShouldNotBeNull();
            elements2.Count().ShouldBeGreaterThan(1);
        }

        [Fact]
        public void DescendantsShouldReturnNull()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xml.message.xml")).Cast<Message>();
            var desc = msg.Descendants<Iq>();
            
            desc.ShouldBeEmpty();
            desc.Count().ShouldBe(0);
        }

        [Fact]
        public void HasDescendantsTest()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xml.message.xml")).Cast<Message>();
            msg.HasDescendants<Iq>().ShouldBe(false);
            msg.HasDescendants<XmppDotNet.Xmpp.XData.Field>().ShouldBe(true);
        }

        [Fact]
        public void FindElementTest()
        {
            var msg = XmppXElement.LoadXml(Resource.Get("Xml.message.xml")).Cast<Message>();
            var elements = msg.Element<XmppDotNet.Xmpp.XData.Data>(true);
            elements.ShouldNotBeNull();
            
            var elements2 = msg.Element<XmppDotNet.Xmpp.XData.Field>(true);
            elements2.ShouldNotBeNull();            
        }

        [Fact]
        public void ShouldCreateEndTag()
        {
            var streamHeader = new Stream() { IsStartTag = true };
            streamHeader.ToString().ShouldBe("<stream:stream xmlns:stream=\"http://etherx.jabber.org/streams\" xmlns=\"jabber:client\" >");
        }

        [Fact]
        public void ShouldCreateStartTga()
        {
            var streamHeader = new Stream() { IsEndTag = true };
            streamHeader.ToString().ShouldBe("</stream:stream>");
        }


        [Fact]
        public void ShouldCreateFirstChildElement()
        {
            var el = new XmppXElement("foo", "a");
            el.FirstXmppXElement = new XmppXElement("foo", "b");
            
            el.ShouldBe("<a xmlns='foo'><b /></a>");


            var el2 = 
                new XmppXElement("foo", "a") 
                {
                    FirstXmppXElement = new XmppXElement("foo", "b")
                };            

            el2.ShouldBe("<a xmlns='foo'><b /></a>");

            el2.FirstXmppXElement = new XmppXElement("foo", "c");
            el2.ShouldBe("<a xmlns='foo'><c/></a>");


            string xml = "<a xmlns='foo'><b>foo</b><c>foo</c></a>";
            var el3 = XmppXElement.LoadXml(xml);
            el3.FirstXmppXElement = new XmppXElement("foo", "c");
            el3.ShouldBe("<a xmlns='foo'><c /><c>foo</c></a>");
        }
    }
}
