﻿namespace XmppDotNet.Tests.Xmpp.MessageArchiveManagement
{
    using XmppDotNet.Xml;
    using XmppDotNet.Xmpp.Client;
    using XmppDotNet.Xmpp.MessageArchiveManagement;
    using Shouldly;
    using Xunit;

    public class MessageArchiveManagementTest
    {
        string MAM_QUERY = @"<iq xmlns='jabber:client' type='set' id='juliet1'>
                                    <query xmlns='urn:xmpp:mam:2' queryid='f27' node='fdp/submitted/capulet.lit/sonnets' />
                                </iq>";
        [Fact]
        public void ShouldBeOfTypeMessageArchive()
        {
            XmppXElement.LoadXml(MAM_QUERY).Cast<Iq>().Query.ShouldBeOfType<MessageArchive>();
        }

        [Fact]
        public void TestQueryId()
        {
            XmppXElement.LoadXml(MAM_QUERY).Cast<Iq>().Query.Cast<MessageArchive>().QueryId.ShouldBe("f27");
        }


        [Fact]
        public void TestQueryNode()
        {
            XmppXElement.LoadXml(MAM_QUERY).Cast<Iq>().Query.Cast<MessageArchive>().Node.ShouldBe("fdp/submitted/capulet.lit/sonnets");
        }

        [Fact]
        public void TestBuildMamQuery()
        {
            var mamQuery = new IqQuery<MessageArchive>
            {
                Type = XmppDotNet.Xmpp.IqType.Set,
                Id = "juliet1", 
                Query =
                {
                    QueryId = "f27",
                    Node = "fdp/submitted/capulet.lit/sonnets"
                }
            };
            mamQuery.ShouldBe(MAM_QUERY);
        }

        [Fact]
        public void testFlippedPages()
        {
            string XML_FLIPPED = @"<iq xmlns='jabber:client' type='set' id='juliet1'>
            <query xmlns='urn:xmpp:mam:2'>     
                  <flip-page/>
              </query>
            </iq>";
            
            string XML_NOT_FLIPPED = @"<iq xmlns='jabber:client' type='set' id='juliet1'>
            <query xmlns='urn:xmpp:mam:2'>    
                  
              </query>
            </iq>";

            var mamQuery = new IqQuery<MessageArchive>
            {
                Type = XmppDotNet.Xmpp.IqType.Set,
                Id = "juliet1", 
                Query =
                {
                    FlipPage = true
                }
            };
            mamQuery.ShouldBe(XML_FLIPPED);
            
            var mamQuery2 = new IqQuery<MessageArchive>
            {
                Type = XmppDotNet.Xmpp.IqType.Set,
                Id = "juliet1", 
                Query =
                {
                    FlipPage = false
                }
            };
            mamQuery2.ShouldBe(XML_NOT_FLIPPED);
        }
    }
}
