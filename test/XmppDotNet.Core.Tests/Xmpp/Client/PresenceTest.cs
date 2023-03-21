namespace XmppDotNet.Tests.Xmpp.Client
{
    using System;
    using XmppDotNet.Xmpp.Client;
    using Shouldly;
    using Xunit;
    using XmppDotNet.Xml;

    public class PresenceTest
    {
        [Fact]
        public void PriorityIsInRange()
        {
            ShouldThrowExtensions.ShouldNotThrow(() => new Presence { Priority = 10 });
            ShouldThrowExtensions.ShouldNotThrow(() => new Presence { Priority = 127 });
            ShouldThrowExtensions.ShouldNotThrow(() => new Presence { Priority = -127 });
        }

        [Fact]
        public void PriorityShouldThrowArgumentException()
        {
            ShouldThrowExtensions.ShouldThrow<ArgumentException>(() => new Presence { Priority = 500 });
            ShouldThrowExtensions.ShouldThrow<ArgumentException>(() => new Presence { Priority = 128 });
            ShouldThrowExtensions.ShouldThrow<ArgumentException>(() => new Presence { Priority = -128 });
        }

        [Fact]
        public void ReadPriority()
        {
            string xml1 = "<presence type='unavailable' xmlns='jabber:client'/>";
            string xml2 = "<presence type='unavailable' xmlns='jabber:client'><priority>10</priority></presence>";
            var el = XmppXElement.LoadXml(xml1);
            el.ShouldBeOfType<Presence>();

            el.Cast<Presence>().Priority.ShouldBe(0);

            var el2 = XmppXElement.LoadXml(xml2);
            el2.ShouldBeOfType<Presence>();

            el2.Cast<Presence>().Priority.ShouldBe(10);
        }
    }
}
