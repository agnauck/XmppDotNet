using Xunit;

using XmppDotNet.Xml;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Client
{
    public class Error
    {
        [Fact]
        public void TestErrors()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error3.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.Forbidden);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error4.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.Gone);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error5.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.InternalServerError);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error6.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.ItemNotFound);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error7.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.JidMalformed);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error8.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.BadRequest);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error9.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.NotAcceptable);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error10.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.NotAuthorized);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error11.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.NotModified);
            XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error12.xml")).Cast<XmppDotNet.Xmpp.Client.Error>().Condition.ShouldBe(XmppDotNet.Xmpp.Base.ErrorCondition.PaymentRequired);
            
            var err = XmppXElement.LoadXml(Resource.Get("Xmpp.Client.error1.xml")).Cast<XmppDotNet.Xmpp.Client.Error>();
            err.Text.ShouldBe("dummy text");
        }

        [Fact]
        public void BuildError()
        {
            var expectedXml1 = Resource.Get("Xmpp.Client.error1.xml");
            var expectedXml2 = Resource.Get("Xmpp.Client.error2.xml");

            new XmppDotNet.Xmpp.Client.Error(XmppDotNet.Xmpp.Base.ErrorCondition.BadRequest)
            {
                Text = "dummy text"
            }
            .ShouldBe(expectedXml1);

            new XmppDotNet.Xmpp.Client.Error(XmppDotNet.Xmpp.Base.ErrorCondition.BadRequest)
            .ShouldBe(expectedXml2);
        }
    }
}
