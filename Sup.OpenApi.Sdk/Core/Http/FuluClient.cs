using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using Sup.OpenApi.Sdk.Core.Http;

/************************************************************************************

 * 机器名称：ZHOUR
 * 公司名称：福禄网络
 * 创建人：  周睿
 * 创建时间：2017/4/7 14:46:26
 * 修订记录：
************************************************************************************/
namespace Sup.OpenApi.Sdk
{
    /// <summary>
    /// HTTP请求封装类
    /// </summary>
    public class FuluClient: IFuluClient
    {
        public FuluClient(string url)
            : this(new Uri(url))
        {

        }

        public HttpWebRequest Request { get; private set; }
        static FuluClient()
        {
            ServicePointManager.DefaultConnectionLimit = 128;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="uri">Uri对象</param>
        public FuluClient(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.KeepAlive = false;

            var isTest = ConfigurationManager.AppSettings["IsTest"];
            if (isTest != null && isTest == "1")
            {
                var proxy = new WebProxy("127.0.0.1", 8888);
                request.Proxy = proxy;
            }
            this.Request = request;
            //request.Method = string.IsNullOrEmpty(method) ? "POST" : method;
            Request.UserAgent = " by zhourui";
            //request.Credentials = CredentialCache.DefaultCredentials;
            Request.Headers.Add("x-charset", "utf-8");
            Request.ContentType = "application/json";


        }

        #region 引入事件，为了拿到请求头
        /// <summary>
        /// 引入事件
        /// </summary>
        public event EventHandler<HttpEventArgs> GetResponseHeadCollection;
        internal void FireResponseHead(WebHeaderCollection headerCollection)
        {
            EventHandler<HttpEventArgs> handler = GetResponseHeadCollection;
            if (handler != null)
            {
                HttpEventArgs eventArgs = new HttpEventArgs(headerCollection);
                handler.Invoke(null, eventArgs);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public class HttpEventArgs : EventArgs
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="headerCollection"></param>
            public HttpEventArgs(WebHeaderCollection headerCollection)
            {
                HeaderCollection = headerCollection;
            }
            /// <summary>
            /// 
            /// </summary>
            public WebHeaderCollection HeaderCollection { get; set; }
        }
        #endregion

        /// <summary>
        /// 绑定cookie
        /// </summary>
        /// <param name="cookieContainer">CookieContainer对象</param>
        public void BindCookie(CookieContainer cookieContainer)
        {
            if (cookieContainer == null)
                throw new ArgumentNullException("cookieContainer");
            this.Request.CookieContainer = cookieContainer;
        }

        /// <summary>
        /// 发生数据
        /// </summary>
        /// <returns></returns>
        public async Task<string> SendAsync()
        {
            return await SendAsync(new byte[0]);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        public async Task<string> SendAsync(byte[] postData)
        {
            if (postData != null && postData.Length > 0)
            {
                this.Request.Method = "POST";

      
                using (BinaryWriter bw = new BinaryWriter(await this.Request.GetRequestStreamAsync()))
                {
                    bw.Write(postData);
                }
            }

            using (HttpWebResponse response = (HttpWebResponse)await this.Request.GetResponseAsync())
            {
                FireResponseHead(response.Headers);
                return await ReadResponseAsync(response);
            }
        }


        public string Send(byte[] postData)
        {
            if (postData != null && postData.Length > 0)
            {
                this.Request.Method = "POST";

                
                using (BinaryWriter bw = new BinaryWriter( this.Request.GetRequestStream()))
                {
                    bw.Write(postData);
                }
            }

            using (HttpWebResponse response = (HttpWebResponse) this.Request.GetResponse())
            {
                FireResponseHead(response.Headers);
                return  ReadResponse(response);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        public async Task<string> SendAsync(string postData)
        {
            if (string.IsNullOrEmpty(postData))
                return await SendAsync(new byte[0]);
            
            return await SendAsync(Encoding.UTF8.GetBytes(postData));
        }

        public  string Send(string postData)
        {
            if (string.IsNullOrEmpty(postData))
                return Send(new byte[0]);
            return Send(Encoding.UTF8.GetBytes(postData));
        }




        private async Task<string> ReadResponseAsync(HttpWebResponse response)
        {
            Stream strem = null;
            if (response.Headers["Content-Encoding"] == "gzip")
                strem = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
            else
                strem = response.GetResponseStream();


            Encoding encoding = (string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet));

            using (StreamReader reader = new StreamReader(strem, encoding))
            {
                return await reader.ReadToEndAsync();
            }
        }

        private string ReadResponse(HttpWebResponse response)
        {
            Stream strem = null;
            if (response.Headers["Content-Encoding"] == "gzip")
                strem = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
            else
                strem = response.GetResponseStream();


            Encoding encoding = (string.IsNullOrEmpty(response.CharacterSet) ? Encoding.UTF8 : Encoding.GetEncoding(response.CharacterSet));

            using (StreamReader reader = new StreamReader(strem, encoding))
            {
                return  reader.ReadToEnd();
            }
        }

    }




}
