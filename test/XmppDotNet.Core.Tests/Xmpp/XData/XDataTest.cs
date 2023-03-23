using System.Linq;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.XData;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.XData
{
    public class XDataTest
    {
        [Fact]
        public void XmlShouldBeTypeOfData()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.xdata1.xml"))
                .ShouldBeOfType<Data>();
        }

        [Fact]
        public void XmlShouldBeTypeOfField()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.field1.xml"))
                .ShouldBeOfType<Field>();
        }

        [Fact]
        public void XmlShouldBeTypeOfDataAndContainTypeOfReported()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.xdata1.xml"))
                .Cast<Data>()
                .Element<Reported>()
                .ShouldNotBeNull();
        }

        [Fact]
        public void TestXdataTitle()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.xdata2.xml"))
                .Cast<Data>()
                .Title.ShouldBe("Joogle Search: verona");
        }


        [Fact]
        public void TestXdataItemCount()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.xdata2.xml"))
                .Cast<Data>()
                .GetItems()
                .Count()
                .ShouldBe(5);
        }

        [Fact]
        public void BuildFromWithFields()
        {
            string expectedXml = Resource.Get("Xmpp.XData.xdata3.xml");

            new Data
            {
                Type = FormType.Result,
                Fields = new [] { new Field("var1", "value1"), new Field("var2", "value2") }
            }
            .ShouldBe(expectedXml);
        }

        [Fact]
        public void BuildFieldWithValues()
        {
            string expectedXml = Resource.Get("Xmpp.XData.field1.xml");
            new Field
            {
                Var = "pubsub#children",
                Values = new[] { "queue1", "queue2", "queue3" }
            }
            .ShouldBe(expectedXml);
        }


        [Fact]
        public void TestFieldTypeTextSingle()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.XData.field2.xml"))
                .Cast<Field>()
                .Type
                .ShouldBe(FieldType.TextSingle);
            
        }
        
        [Fact]
        public void TestBuildTextSingleField()
        {
            var xmlExpected = Resource.Get("Xmpp.XData.field2.xml");
                
            new Field
            {
                Type = FieldType.TextSingle,
                Var = "muc#roomconfig_roomname",
                Label = "Natural-Language Room Name"
            }
            .ShouldBe(xmlExpected);
        }

        [Fact]
        public void TestBoolValued()
        {
            var fieldFalse1 = XmppXElement.LoadXml("<field xmlns='jabber:x:data' type='boolean' var='public'><value>0</value></field>") as Field;
            var fieldFalse2 = XmppXElement.LoadXml("<field xmlns='jabber:x:data' type='boolean' var='public'><value>false</value></field>") as Field;
            var fieldTrue1 = XmppXElement.LoadXml("<field xmlns='jabber:x:data' type='boolean' var='public'><value>1</value></field>") as Field;
            var fieldTrue2 = XmppXElement.LoadXml("<field xmlns='jabber:x:data' type='boolean' var='public'><value>true</value></field>") as Field;


            fieldFalse1.GetValueBool().ShouldBeFalse();
            fieldFalse2.GetValueBool().ShouldBeFalse();

            fieldTrue1.GetValueBool().ShouldBeTrue();
            fieldTrue2.GetValueBool().ShouldBeTrue();
        }
    }
}
