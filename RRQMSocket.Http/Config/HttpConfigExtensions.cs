using RRQMSocket.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMSocket
{
    /// <summary>
    /// HttpConfigExtensions
    /// </summary>
    public static class HttpConfigExtensions
    {
        #region 创建
        /// <summary>
        /// 构建Http类客户端，并连接
        /// </summary>
        /// <typeparam name="TClient"></typeparam>
        /// <param name="config"></param>
        /// <returns></returns>
        public static TClient BuildWithHttpClient<TClient>(this RRQMConfig config) where TClient : IHttpClient
        {
            TClient client = config.Container.Resolve<TClient>();
            client.Setup(config);
            client.Connect();
            return client;
        }

        /// <summary>
        /// 构建Http类客户端，并连接
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static HttpClient BuildWithHttpClient(this RRQMConfig config)
        {
            return BuildWithHttpClient<HttpClient>(config);
        }


        /// <summary>
        /// 构建Http类服务器，并启动。
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <param name="config"></param>
        /// <returns></returns>
        public static TService BuildWithHttpService<TService>(this RRQMConfig config) where TService : IHttpService
        {
            TService service = config.Container.Resolve<TService>();
            service.Setup(config);
            service.Start();
            return service;
        }

        /// <summary>
        /// 构建Http类服务器，并启动。
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public static HttpService BuildWithHttpService(this RRQMConfig config)
        {
            return BuildWithHttpService<HttpService>(config);
        }
        #endregion
    }
}
