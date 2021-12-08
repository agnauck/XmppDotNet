using XmppDotNet.Attributes;

namespace XmppDotNet.Xmpp.Compression.Features
{
    [XmppTag(Name = "method", Namespace = Namespaces.FeatureCompress)]
    public class Method : Xmpp.Compression.Method
    {
        public Method() : base(Namespaces.FeatureCompress)
        {
        }

        public Method(Methods method) : this()
        {
            Value = method.GetName();
        }
    }
}
