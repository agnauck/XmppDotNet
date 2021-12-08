using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.HttpUpload
{
    public enum HeaderNames
    {
        [Name("Authorization")]
        Authorization,

        [Name("Cookie")]
        Cookie,

        [Name("Expires")]
        Expires
    }
}
