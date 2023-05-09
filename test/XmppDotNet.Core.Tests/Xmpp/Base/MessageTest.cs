using System;
using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Client;
using XmppDotNet.Xmpp.Oob;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Base;

public class MessageTest
{
    [Fact]
    public void TestXOob()
    {
        string xml = @"<message xmlns='jabber:client'>            
            <x xmlns='jabber:x:oob'>
            <url>https://palaver.im/upload/5bb502b7c5289e610734e07c6a499759f520bf98/KF2b34g.jpg</url>
            </x>
            <body>https://palaver.im/upload/5bb502b7c5289e610734e07c6a499759f520bf98/KF2b34g.jpg</body>
            </message>";

        var msg = XmppXElement.LoadXml(xml).Cast<Message>();
        msg.XOob.ShouldNotBeNull();
        msg.XOob.Uri.ToString().ShouldBe("https://palaver.im/upload/5bb502b7c5289e610734e07c6a499759f520bf98/KF2b34g.jpg");
        
        new Message()
        {
            Body = "https://palaver.im/upload/5bb502b7c5289e610734e07c6a499759f520bf98/KF2b34g.jpg",
            XOob = new XOob(){Uri = new Uri("https://palaver.im/upload/5bb502b7c5289e610734e07c6a499759f520bf98/KF2b34g.jpg")}
        }
        .ShouldBe(xml);
    }

}