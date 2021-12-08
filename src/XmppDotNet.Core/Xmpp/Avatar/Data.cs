namespace XmppDotNet.Xmpp.Avatar
{
    using XmppDotNet.Attributes;
    using XmppDotNet.Xmpp.Base;

    /// <summary>
    /// Represents the avatar data element
    /// </summary>
    [XmppTag(Name = "data", Namespace = Namespaces.AvatarData)]
    public class Data : XmppXElementWithBased64Value
    {
        public Data()
            : base(Namespaces.AvatarData, "data")
        {
        }
    }
}
