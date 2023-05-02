using System;
using System.Linq;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.MessageArchiving;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Archiving
{
    public class ArchivingTests
    {
        [Fact]
        public void XmlShoudbeOfTypeChat()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml")).ShouldBeOfType<Chat>();
        }

        [Fact]
        public void TestChatSubject()
        {
            var chat = XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml")).Cast<Chat>();
            Assert.Equal("She speaks!", chat.Subject);
        }

        [Fact]
        public void TestChatWith()
        {
            var chat = XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml")).Cast<Chat>();
            Assert.Equal("juliet@capulet.com/chamber", chat.With.ToString());
        }
        
        [Fact]
        public void TestChatItems()
        {
            var chat = XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml")).Cast<Chat>();
            Assert.Equal(3, chat.GetItems().Count());
        }


        [Fact]
        public void TestChatToBody()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml"))
                .Cast<Chat>()
                .Element<To>()
                .Body
                .ShouldBe("Neither, fair saint, if either thee dislike.");
        }

        [Fact]
        public void TestChatToSeconds()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml"))
                .Cast<Chat>()
                .Element<To>()
                .Seconds.ShouldBe(11);
        }

        [Fact]
        public void TestChatFromBody()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml"))
                .Cast<Chat>()
                .Element<From>()
                .Body.ShouldBe("Art thou not Romeo, and a Montague?");

        }

        [Fact]
        public void TestChatFromTimestamp()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.chat.xml"))
                .Cast<Chat>()
                .Element<From>()
                .TimeStamp.ToUniversalTime().ShouldBe(new DateTime(1469, 07, 21, 0, 32, 29, DateTimeKind.Utc));
        }

        [Fact]
        public void XmlShoudbeOfTypePref()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.pref.xml")).ShouldBeOfType<Preferences>();
        }
        
        [Fact]
        public void TestPreferenceProperties()
        {
            var prefs = XmppXElement.LoadXml(Resource.Get("Xmpp.Archiving.pref.xml")).Cast<Preferences>();
         
            Assert.True(prefs.Auto != null);
            Assert.True(prefs.Auto.Save);

            Assert.True(prefs.Default != null);
            Assert.Equal(31536000, prefs.Default.Expire);
            Assert.True(prefs.Default.Otr == OtrType.Concede);
            Assert.True(prefs.Default.Save == SaveType.Body);

            Assert.True(prefs.Session != null);
            Assert.Equal("ffd7076498744578d10edabfe7f4a866", prefs.Session.Thread);
            Assert.True(prefs.Default.Save == SaveType.Body);

            // first: <method type='auto' use='forbid'/> 
            Assert.Equal(3, prefs.GetMethods().Count());
            Assert.True(prefs.GetMethods().First().Type == MethodType.Auto);
            Assert.True(prefs.GetMethods().First().Use == UseType.Forbid);
        }

        [Fact]
        public void BuildListQuery()
        {
            var expectedXml = Resource.Get("Xmpp.Archiving.list.xml");
            new List { With = "juliet@capulet.com" }.ShouldBe(expectedXml);
        }

        [Fact]
        public void BuildIqQuery()
        {
            var expectedXml = Resource.Get("Xmpp.Archiving.iq1.xml");
            new XmppDotNet.Xmpp.Client.Iq
            {
                Type = XmppDotNet.Xmpp.IqType.Get,
                Id = "foo",
                Query = new List { With = "juliet@capulet.com" }
            }
            .ShouldBe(expectedXml);
        }

        [Fact]
        public void BuildRetrieveQuery()
        {
            var expectedXml = Resource.Get("Xmpp.Archiving.iq2.xml");
            new XmppDotNet.Xmpp.Client.Iq
            {
                Type = XmppDotNet.Xmpp.IqType.Get,
                Id = "page1",
                Query = new Retrieve
                {
                    With = "juliet@capulet.com/chamber",
                    Start = new DateTime(1469, 07, 21, 2, 56, 15, DateTimeKind.Utc),
                    ResultSet = new XmppDotNet.Xmpp.ResultSetManagement.Set
                    {
                        Max = 100
                    }
                }
            }
            .ShouldBe(expectedXml);
        }
    }
}
