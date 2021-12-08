using System;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.AdHocCommands;
using Xunit;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.AdHocCommands
{
    public class ActionsTests
    {
        private const string XML1
          = @"<actions execute='complete'
                xmlns='http://jabber.org/protocol/commands'>
              <prev/>
              <complete/>
            </actions>";

        [Fact]
        public void Test1()
        {
            XmppXElement xmpp1 = XmppXElement.LoadXml(XML1);
            xmpp1.ShouldBeOfType<Actions>();

            var actions = xmpp1 as Actions;
            if (actions != null)
            {
                actions.Execute.ShouldBe(XmppDotNet.Xmpp.AdHocCommands.Action.Complete);
                actions.Execute.ShouldNotBe(XmppDotNet.Xmpp.AdHocCommands.Action.Execute);
                actions.Execute.ShouldNotBe(XmppDotNet.Xmpp.AdHocCommands.Action.None);

                actions.Previous.ShouldBeTrue();
                actions.Complete.ShouldBeTrue();
                actions.Next.ShouldBeFalse();

                actions.Action.ShouldBe(XmppDotNet.Xmpp.AdHocCommands.Action.Complete | XmppDotNet.Xmpp.AdHocCommands.Action.Prev);
            }
        }

        [Fact]
        public void TestException()
        {
            Should.Throw<NotSupportedException>(() =>
                new Actions {Execute = XmppDotNet.Xmpp.AdHocCommands.Action.Execute});
        }

        [Fact]
        public void TestException2()
        {
            Should.Throw<NotSupportedException>(
                () =>
                    new Actions {Execute = XmppDotNet.Xmpp.AdHocCommands.Action.Cancel});
        }

        [Fact]
        public void TestException3()
        {
            Should.Throw<NotSupportedException>(() =>
                new Actions
                {
                    Action = XmppDotNet.Xmpp.AdHocCommands.Action.Complete | XmppDotNet.Xmpp.AdHocCommands.Action.Execute
                });
        }


    }
}
