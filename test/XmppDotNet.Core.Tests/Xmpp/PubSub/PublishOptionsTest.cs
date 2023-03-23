using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;

using Shouldly;
using Xunit;
using System.Linq;

namespace XmppDotNet.Tests.Xmpp.PubSub
{
    public class PublishOptionsTest
    {
        [Fact]
        public void ShoudBeOfTypePublish()
        {
            var iq = XmppXElement.LoadXml(Resource.Get("Xmpp.PubSub.publish-options1.xml")) as Iq;
            var pubsub = iq.Element<XmppDotNet.Xmpp.PubSub.PubSub>();
            pubsub.PublishOptions.ShouldNotBeNull();

            pubsub.PublishOptions.XData.Type.ShouldBe(XmppDotNet.Xmpp.XData.FormType.Submit);
            pubsub.PublishOptions.XData.GetFields().Count().ShouldBe(5);
        }

        [Fact]
        public void TestBuildPublishOptions()
        {
            string expectedXml =
             @"<publish-options xmlns='http://jabber.org/protocol/pubsub'>
	            <x xmlns='jabber:x:data' type='submit'>
		            <field var='FORM_TYPE' type='hidden'>
			            <value>http://jabber.org/protocol/pubsub#publish-options</value>
		            </field>
		            <field var='pubsub#persist_items'>
			            <value>true</value>
		            </field>
		            <field var='pubsub#max_items'>
			            <value>10000</value>
		            </field>
		            <field var='pubsub#send_last_published_item'>
			            <value>never</value>
		            </field>
		            <field var='pubsub#access_model'>
			            <value>whitelist</value>
		            </field>
	            </x>
            </publish-options>";

            var publishOptions = new XmppDotNet.Xmpp.PubSub.PublishOptions();
            var data = new XmppDotNet.Xmpp.XData.Data { Type = XmppDotNet.Xmpp.XData.FormType.Submit };
            data.AddField("FORM_TYPE", "http://jabber.org/protocol/pubsub#publish-options", XmppDotNet.Xmpp.XData.FieldType.Hidden);
            data.AddField("pubsub#persist_items", "true");
            data.AddField("pubsub#max_items", "10000");
            data.AddField("pubsub#send_last_published_item", "never");
            data.AddField("pubsub#access_model", "whitelist");

            publishOptions.XData = data;
            publishOptions.ShouldBe(expectedXml);
        }

        [Fact]
        public void TestBuildPublishOptionsInlineApi()
        {
            string expectedXml =
             @"<publish-options xmlns='http://jabber.org/protocol/pubsub'>
	            <x xmlns='jabber:x:data' type='submit'>
		            <field var='FORM_TYPE' type='hidden'>
			            <value>http://jabber.org/protocol/pubsub#publish-options</value>
		            </field>
		            <field var='pubsub#persist_items'>
			            <value>true</value>
		            </field>
		            <field var='pubsub#max_items'>
			            <value>10000</value>
		            </field>
		            <field var='pubsub#send_last_published_item'>
			            <value>never</value>
		            </field>
		            <field var='pubsub#access_model'>
			            <value>whitelist</value>
		            </field>
	            </x>
            </publish-options>";

            var publishOptions = new XmppDotNet.Xmpp.PubSub.PublishOptions() {
                XData = new XmppDotNet.Xmpp.XData.Data {
                    Type = XmppDotNet.Xmpp.XData.FormType.Submit,
                    Fields = new XmppDotNet.Xmpp.XData.Field[] {
                        new XmppDotNet.Xmpp.XData.Field {
                            Var = "FORM_TYPE",
                            Values = new string [] { "http://jabber.org/protocol/pubsub#publish-options" },
                            Type = XmppDotNet.Xmpp.XData.FieldType.Hidden
                        },
                        new XmppDotNet.Xmpp.XData.Field {
                            Var = XmppDotNet.Xmpp.XData.FormTypes.PubsubNodeConfigPersistItems,
                            Values = new string [] { "true" }
                        },
                        new XmppDotNet.Xmpp.XData.Field {
                            Var = XmppDotNet.Xmpp.XData.FormTypes.PubsubNodeConfigMaxItems,
                            Values = new string [] { "10000" }
                        },
                        new XmppDotNet.Xmpp.XData.Field {
                            Var = XmppDotNet.Xmpp.XData.FormTypes.PubsubNodeConfigSendLastPublishedItem,
                            Values = new string [] { "never" }
                        },
                        new XmppDotNet.Xmpp.XData.Field {
                            Var =  XmppDotNet.Xmpp.XData.FormTypes.PubsubNodeConfigAccessModel,
                            Values = new string [] { "whitelist" }
                        }
                    }
                }
            };

            publishOptions.ShouldBe(expectedXml);
        }
    }
}
