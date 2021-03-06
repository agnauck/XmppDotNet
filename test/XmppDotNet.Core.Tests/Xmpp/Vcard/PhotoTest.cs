using System;
using Xunit;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Vcard;
using Shouldly;

namespace XmppDotNet.Tests.Xmpp.Vcard
{
    public class PhotoTest
    {
        [Fact]
        public void XmlShouldBeTypeOfPhoto()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo1.xml")).ShouldBeOfType<Photo>();
            XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo2.xml")).ShouldBeOfType<Photo>();
            XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo3.xml")).ShouldBeOfType<Photo>();
        }

        [Fact]
        public void TestPhoto1()
        {
            var photo = XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo1.xml")).Cast<Photo>();
            byte[] b1 = photo.Binval;

            byte[] bcheck =
                Convert.FromBase64String(@"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
ocUxKLzi8Tpr6l2TAf//Z");

            b1.ShouldBe(bcheck);
        }

        [Fact]
        public void TestPhoto2()
        {
            var photo2 = XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo2.xml")).Cast<Photo>();
            byte[] b2 = photo2.Binval;
            b2.ShouldBe(new byte[0]);
        }

        [Fact]
        public void TestPhoto3()
        {
            var photo3 = XmppXElement.LoadXml(Resource.Get("Xmpp.Vcard.photo3.xml")).Cast<Photo>();
            byte[] b3 = photo3.Binval;
            Assert.Null(b3);
        }
    }
}
