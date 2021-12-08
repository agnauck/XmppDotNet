using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Compression;
using Shouldly;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.Stream
{
    public class FeaturesTest
    {
        [Fact]
        public void TestShouldbeOfTypeStreamFeatures()
        {
            XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.stream_features1.xml")).ShouldBeOfType<XmppDotNet.Xmpp.Stream.StreamFeatures>();
        }

        [Fact]
        public void TestStreamFeatures()
        {
            var feats = XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.stream_features1.xml")).Cast<XmppDotNet.Xmpp.Stream.StreamFeatures>();

            Assert.True(feats.SupportsCompression);
            Assert.True(feats.SupportsAuth);
            Assert.True(feats.Compression.Supports(Methods.Zlib));
        }

        [Fact]
        public void TestCompression()
        {
            var comp = XmppXElement.LoadXml(Resource.Get("Xmpp.Stream.compression2.xml")).Cast<XmppDotNet.Xmpp.Stream.Features.Compression>();

            Assert.False(comp.Supports(Methods.Zlib));

            var method = comp.Element<Method>();
            Assert.True(method.CompressionMethod == Methods.Unknown);
        }
    }
}
