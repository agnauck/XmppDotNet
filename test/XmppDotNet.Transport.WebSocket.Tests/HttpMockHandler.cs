namespace XmppDotNet.Transport.WebSocket.Tests
{
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class HttpMockHandler: HttpMessageHandler {
        public string Response { get; set; } = "{}";
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage req, CancellationToken ct) 
            => Task.FromResult(new HttpResponseMessage { 
                StatusCode = HttpStatusCode.OK, 
                Content = new StringContent(Response) 
            });
    }    
}
