using System.Threading.Tasks;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using System.Threading;

namespace XmppDotNet.Sasl
{
    public interface IAuthenticate
    {
        Task<XmppXElement> AuthenticateAsync(Mechanisms mechanisms, IXmppClient xmppClient, CancellationToken cancellationToken);
    }
}
