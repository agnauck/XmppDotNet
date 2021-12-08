using System.Threading.Tasks;
using XmppDotNet.Sasl.Digest;
using XmppDotNet.Sasl.Plain;
using XmppDotNet.Sasl.Scram;
using XmppDotNet.Xml;
using XmppDotNet.Xmpp.Sasl;
using System.Threading;

namespace XmppDotNet.Sasl
{
    public class DefaultSaslHandler : IAuthenticate
    {
        public async Task<XmppXElement> AuthenticateAsync(Mechanisms mechanisms, IXmppClient xmppClient, CancellationToken cancellationToken)
        {
            ISaslProcessor saslProc = null;
            if (mechanisms.SupportsMechanism(SaslMechanism.ScramSha1))
                saslProc = new ScramSha1Processor();

            else if (mechanisms.SupportsMechanism(SaslMechanism.DigestMd5))
                saslProc = new DigestMd5Processor();

            else if (mechanisms.SupportsMechanism(SaslMechanism.Plain))
                saslProc = new PlainProcessor();

            return await saslProc.AuthenticateClientAsync(xmppClient, cancellationToken).ConfigureAwait(false);
        }
    }
}
