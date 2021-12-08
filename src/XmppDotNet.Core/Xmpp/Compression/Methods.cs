using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Compression
{
    public enum Methods
    {
        [Name("")]
        Unknown = -1,
        
        [Name("zlib")]
        Zlib,

        [Name("lzw")]
        Lzw
    }
}
