using System.Threading.Tasks;
using XmppDotNet.Xml;
using System.Threading;

namespace XmppDotNet.Sasl
{
    public interface ISaslProcessor
    {
        Task<XmppXElement> AuthenticateClientAsync(IXmppClient xmppClient, CancellationToken cancellationToken);
    }
}
