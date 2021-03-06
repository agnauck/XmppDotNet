using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Jingle
{
    // see: http://www.iana.org/assignments/mail-cont-disp/mail-cont-disp.xml
    public enum Disposition
    {
        [Name("inline")]
        Inline,                     //	displayed automatically	[RFC2183]

        [Name("attachment")]
        Attachment,                 //	user controlled display	[RFC2183]

        [Name("form-data")]
        FormData ,                  //	process as form response	[RFC2388]

        [Name("signal")]
        Signal,                     //	tunneled content to be processed silently	[RFC3204]

        [Name("alert")]
        Alert,                      //	the body is a custom ring tone to alert the user	[RFC3261]

        [Name("icon")]
        Icon,                       //	the body is displayed as an icon to the user	[RFC3261]

        [Name("render")]
        Render,                     //	the body should be displayed to the user	[RFC3261]

        [Name("recipient-list-history")]
        RecipientListHistory,       //	the body contains a list of URIs that indicates the recipients of the request	[RFC5364]

        [Name("session")]
        Session,                    //	the body describes a communications session, for example, an RFC2327 SDP body	[RFC3261]

        [Name("signed-receipt-protocol")]
        SignedReceiptProtocol,      //	requested signature format for signed receipt	[RFC3335]

        [Name("signed-receipt-micalg")]
        SignedReceiptMicalg,        //	requested signature algorithm for signed receipt	[RFC3335]

        [Name("aib")]
        Aib,                        //	Authenticated Identity Body	[RFC3893]

        [Name("early-session")]
        EarlySession,               //	the body describes an early communications session, for example, and [RFC2327] SDP body	[RFC3959]

        [Name("recipient-list")]
        RecipientList,              //	The body includes a list of URIs to which URI-list services are to be applied.	[RFC5363]

        [Name("notification")]
        Notification,               //	the payload of the message carrying this Content-Disposition header field value is an Instant Message Disposition Notification as requested in the corresponding Instant Message.	[RFC5438]

        [Name("by-reference")]
        ByReference,                //	The body needs to be handled according to a reference to the body that is located in the same SIP message as the body.	[RFC-ietf-sip-body-handling-06]

        [Name("info-package")]
        InfoPackage,                //	The body cont
    }
}
