using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    public class OutputResponseDto
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
        /// <summary>
        /// 状态码描述
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 响应结果
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
        /// <summary>
        /// 响应签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }
    }
}
