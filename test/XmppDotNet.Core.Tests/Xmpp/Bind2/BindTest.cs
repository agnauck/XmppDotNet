using XmppDotNet.Xml;
using Shouldly;
using XmppDotNet.Xmpp.Bind2;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Bind2
{
    public class BindTest
    {
        [Fact]
        public void ShouldBeOfTypeBind()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Bind2.bind.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Bind2.Bind>();
        }

        [Fact]
        public void TestBind()
        {
            var bind 
                = XmppXElement
                    .LoadXml(Resource.Get("Xmpp.Bind2.bind.xml"))
                    .Cast<XmppDotNet.Xmpp.Bind2.Bind>();
            
            bind.Tag.ShouldBe("AwesomeXMPP");
        }
        
        [Fact]
        public void BuildBindElement()
        {
            var bind = new Bind()
            {
                Tag = "AwesomeXMPP"
            };
            
            bind.ShouldBe(Resource.Get("Xmpp.Bind2.bind2.xml"));
        }
        
        [Fact]
        public void TestInlineElement()
        {
            var bind 
                = XmppXElement
                    .LoadXml(Resource.Get("Xmpp.Bind2.bind3.xml"))
                    .Cast<XmppDotNet.Xmpp.Bind2.Bind>();
            
            bind.Inline.ShouldNotBeNull();
            bind.Inline.SupportMessageCarbons.ShouldBeTrue();
            bind.Inline.SupportsStreamManagement.ShouldBeTrue();
            bind.Inline.SupportsClientStateIndication.ShouldBeTrue();
        }
        
        [Fact]
        public void TestBuildBindElementWithBindFeatures()
        {
            var bind = new Bind()
            {
                Tag = "AwesomeXMPP"
            };

            bind.Add(new XmppDotNet.Xmpp.MessageCarbons.Enable());
            bind.Add(new XmppDotNet.Xmpp.StreamManagement.Enable());
            bind.Add(new XmppDotNet.Xmpp.Csi.Inactive());
            
            bind.ShouldBe(Resource.Get("Xmpp.Bind2.bind4.xml"));
        }
    }
}
