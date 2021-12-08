namespace XmppDotNet.Transport.WebSocket
{
    public static class WebSocketConfigurationExtensions
    {
        /// <summary>
        /// Use WebSocket Transport
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="resolver"></param>
        /// <returns></returns>
        public static XmppDotNet.Configuration UseWebSocketTransport(
            this Configuration configuration,
            IResolver resolver)
        {
            configuration.Transport = new WebSocketTransport() {Resolver = resolver};
            return configuration;
        }

        /// <summary>
        /// Use WebSocket Transport
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static Configuration UseWebSocketTransport(
            this Configuration configuration)
        {
            configuration.Transport = new WebSocketTransport();
            return configuration;
        }
    }
}
