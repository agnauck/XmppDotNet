using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Sasl
{
    public enum SaslMechanism
    {
        [Name(null)]
        None,

        [Name("GSSAPI")]
        Gssapi,
        
        [Name("NTLM")]
        Ntlm,

        [Name("EXTERNAL")]
        External,

        [Name("SCRAM-SHA-1")]
        ScramSha1,
        
        [Name("SCRAM-SHA-1-PLUS")]
        ScramSha1Plus,

        [Name("ANONYMOUS")]
        Anonymous,

        [Name("PLAIN")]
        Plain,
        
        [Name("DIGEST-MD5")]
        DigestMd5,
        
        [Name("X-GOOGLE-TOKEN")]
        XGoogleToken,
        
        [Name("X-FACEBOOK-PLATFORM")]
        XFacebookPlatform,
        
        [Name("X-MESSENGER-OAUTH2")]
        XMessengerOauth2,
        
        [Name("X-OAUTH2")]
        XOauth2,
        
        [Name("CISCO-VTG-TOKEN")]
        CiscoVtgToken,
        
        [Name("WEBEX-TOKEN")]
        WebexToken
    }
}
