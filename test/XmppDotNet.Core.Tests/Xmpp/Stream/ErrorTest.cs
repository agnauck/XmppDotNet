using XmppDotNet.Xml;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Stream
{
    public class ErrorTest
    {
        [Fact]
        public void TestBuildstreamError()
        {
            new XmppDotNet.Xmpp.Stream.Error(XmppDotNet.Xmpp.Stream.ErrorCondition.ResourceConstraint)
                .ShouldBe(Resource.Get("Xmpp.Stream.stream_error1.xml"));

            new XmppDotNet.Xmpp.Stream.Error(XmppDotNet.Xmpp.Stream.ErrorCondition.InvalidXml)
                .ShouldBe(Resource.Get("Xmpp.Stream.stream_error2.xml"));
        }

        [Fact]
        public void TestShouldbeOfTypeError()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.stream_error1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Stream.Error>();
        }

        [Fact]
        public void TestStreamError1()
        {
            var error = XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.stream_error1.xml")).Cast<XmppDotNet.Xmpp.Stream.Error>();
            Assert.True(error.Condition == XmppDotNet.Xmpp.Stream.ErrorCondition.ResourceConstraint);
        }

        [Fact]
        public void TestStreamError2()
        {
            var error = XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.stream_error2.xml")).Cast<XmppDotNet.Xmpp.Stream.Error>();
            Assert.True(error.Condition == XmppDotNet.Xmpp.Stream.ErrorCondition.InvalidXml);
        }
    }
}
