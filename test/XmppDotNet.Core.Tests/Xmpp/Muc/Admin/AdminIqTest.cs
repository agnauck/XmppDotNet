using Xunit;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Muc.Admin;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Muc.Admin
{
    public class AdminIqTest
    {
        [Fact]
        public void ShoudBeOfTypeAdminQuery()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Muc.Admin.admin_query1.xml")).ShouldBeOfType<AdminQuery>();
        }

        [Fact]
        public void TestBuildAdminQuery()
        {
            var aIq = new AdminIq();
            aIq.AdminQuery.AddItem(new Item(XmppDotNet.Xmpp.Muc.Role.None, "pistol", "my reason!"));
            aIq.Id = "1";
            aIq.ShouldBe(Resource.Get("Xmpp.Muc.Admin.admin_iq1.xml"));
        }
    }
}
