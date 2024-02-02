using Shouldly;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.MessageArchiveManagement;
using Xunit;

namespace XmppDotNet.Tests.Xmpp.MessageArchiveManagement;

public class MetadataTest
{
    [Fact]
    public void XmlShouldBeOfTypeMetaData()
    {
        XmppXElement.LoadXml(Resource.Get("Xmpp.MessageArchiveManagement.metadata.xml"))
            .ShouldBeOfType<MetaData>();
    }
    
    [Fact]
    public void MetaDataWithStart()
    {
        var meta = XmppXElement
            .LoadXml(Resource.Get("Xmpp.MessageArchiveManagement.metadata.xml"))
            .Cast<MetaData>();
        
        meta.Start.ShouldNotBeNull();
        meta.Start.Id.ShouldBe("YWxwaGEg");
        meta.Start.Timestamp.Year.ShouldBe(2008);
    }
    
    [Fact]
    public void MetaDataWithEnd()
    {
        var meta = XmppXElement
            .LoadXml(Resource.Get("Xmpp.MessageArchiveManagement.metadata.xml"))
            .Cast<MetaData>();
        
        meta.End.ShouldNotBeNull();
        meta.End.Id.ShouldBe("b21lZ2Eg");
        meta.End.Timestamp.Year.ShouldBe(2020);
    }
}