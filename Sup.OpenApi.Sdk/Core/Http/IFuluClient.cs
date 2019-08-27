using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.OpenApi.Sdk.Core.Http
{
    public interface IFuluClient
    {
        /// <summary>
        /// 异步请求openapi2.0
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        Task<string> SendAsync(string postData);

        /// <summary>
        /// 同步请求openapi2.0
        /// </summary>
        /// <param name="postData"></param>
        /// <returns></returns>
        string Send(string postData);
    }
}
