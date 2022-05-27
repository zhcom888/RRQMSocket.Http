using RRQMSocket.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMSocket
{
    /// <summary>
    /// WebSocketConfigExtensions
    /// </summary>
    public static class WebSocketConfigExtensions
    {

        /// <summary>
        /// 构建WebSocketClient类客户端，并连接
        /// </summary>
        /// <typeparam name="TClient"></typeparam>
        /// <param name="config"></param>
        /// <returns></returns>
        public static TClient BuildWithWebSocketClient<TClient>(this RRQMConfig config) where TClient : IWebSocketClient
        {
            TClient client= config.Container.Resolve<TClient>();
            client.Setup(config);
            client.Connect();
            return client;
        }

        /// <summary>
        /// 构建WebSocketClient类客户端，并连接
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static WebSocketClient BuildWithWebSocketClient(this RRQMConfig config)
        {
            return BuildWithWebSocketClient<WebSocketClient>(config);
        }
    }
}
