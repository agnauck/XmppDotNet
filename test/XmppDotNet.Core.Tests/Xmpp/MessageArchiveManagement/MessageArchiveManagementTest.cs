using XmppDotNet.Xmpp;
using XmppDotNet.Xmpp.ResultSetManagement;
using XmppDotNet.Xmpp.XData;

namespace XmppDotNet.Tests.Xmpp.MessageArchiveManagement
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
        public void TestFlippedPages()
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

        [Fact]
        public void TestMamQueryWithResultSet()
        {
            string XML = @"<iq type='result' id='q29302' xmlns='jabber:client'>
                          <fin xmlns='urn:xmpp:mam:2'>
                            <set xmlns='http://jabber.org/protocol/rsm'>
                              <first index='0'>28482-98726-73623</first>
                              <last>09af3-cc343-b409f</last>
                              <count>20</count>
                            </set>
                          </fin>
                        </iq>";

            var iq = XmppXElement.LoadXml(XML);
            var fin = iq.Element<Final>();
            fin.ResultSet.ShouldNotBeNull();
            fin.ResultSet.First.Index.ShouldBe(0);
            fin.ResultSet.First.Value.ShouldBe("28482-98726-73623");
            fin.ResultSet.Last.ShouldBe("09af3-cc343-b409f");
            fin.ResultSet.Count.ShouldBe(20);
            
            var mamQuery2 = new IqQuery<Final>
            {
                Type = IqType.Result,
                Id = "q29302", 
                Query =
                {
                    ResultSet = new Set
                    {
                        First = new First
                        {
                            Index = 0,
                            Value = "28482-98726-73623"
                        },
                        Last = "09af3-cc343-b409f",
                        Count = 20
                    }
                   
                }
            };
            mamQuery2.ShouldBe(XML);
        }

        [Fact]
        public void TestMamQueryWithXData()
        {
            string XML = @"<iq type='set' id='juliet1' xmlns='jabber:client'>
                    <query xmlns='urn:xmpp:mam:2'>
                        <x xmlns='jabber:x:data' type='submit'>
                            <field var='FORM_TYPE' type='hidden'>
                                <value>urn:xmpp:mam:2</value>
                            </field>
                            <field var='with'>
                                <value>juliet@capulet.lit</value>
                            </field>
                        </x>
                    </query>
                </iq>";
            
            var mamQuery2 = new IqQuery<MessageArchive>
            {
                Type = IqType.Set,
                Id = "juliet1", 
                Query =
                {
                    XData =new Data
                    {
                        Type = FormType.Submit,
                        Fields = new []
                        {
                            new Field
                            {
                                Var = "FORM_TYPE",
                                Type = FieldType.Hidden,
                                Values = new [] { Namespaces.MessageArchiveManagement }
                            },
                            new Field
                            {
                                Var = "with",
                                Values = new [] { "juliet@capulet.lit" }
                            }
                        }
                    }
                }
            };
            mamQuery2.ShouldBe(XML);
        }

        [Fact]
        public void TestMamMessage()
        {
            string XML = @"<message to='romeo@palaver.im/1136298492271220274312957890' from='xsf@muc.xmpp.org' xmlns='jabber:client'>
                <result xmlns='urn:xmpp:mam:2' id='2023-05-03-15cd4bcb5c732264' queryid='28ca889c-6a5a-41f0-accd-edbd2810487d'>
                    <forwarded xmlns='urn:xmpp:forward:0'>
                        <delay xmlns='urn:xmpp:delay' stamp='2023-05-03T14:05:57Z' />
                        <message xmlns='jabber:client' id='59faed25-f40e-43e5-949e-bc4de5855918' xml:lang='en' type='groupchat' from='xsf@muc.xmpp.org/edhelas'>
                            <active xmlns='http://jabber.org/protocol/chatstates' />
                            <origin-id xmlns='urn:xmpp:sid:0' id='59faed25-f40e-43e5-949e-bc4de5855918' />
                            <body>Hello World</body>
                            <occupant-id xmlns='urn:xmpp:occupant-id:0' id='cVCDehgrfs11FZL0SRpjNtjuGeRt3c2stgYd+HcLY=' />
                        </message>
                    </forwarded>
                </result>
            </message>";

            var msg = XmppXElement.LoadXml(XML).Cast<Message>();
            
            msg.IsMamResult.ShouldBeTrue();
            msg.MamResult.Forwarded.ShouldNotBeNull();
            msg.MamResult.Forwarded.Message .ShouldNotBeNull();
            msg.MamResult.Forwarded.Message.Body.ShouldBe("Hello World");
            msg.MamResult.Forwarded.Message.OccupantId.Id.ShouldBe("cVCDehgrfs11FZL0SRpjNtjuGeRt3c2stgYd+HcLY=");
        }
    }
}
