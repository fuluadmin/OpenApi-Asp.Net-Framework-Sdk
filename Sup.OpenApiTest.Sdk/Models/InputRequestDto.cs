using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sup.OpenApiTest.Sdk.Models
{
    public class InputRequestDto
    {
        /// <summary>
        /// 开放平台分配给商户的AppKey
        /// </summary>
        [JsonProperty("app_key")]
        public string AppKey { get; set; }
        /// <summary>
        /// 接口方法名称
        /// </summary>\
        [JsonProperty("method")]
        public string Method { get; set; }
        /// <summary>
        /// 请求参数集合
        /// </summary>
        [JsonProperty("biz_content")]
        public string BizContent { get; set; }
    }
}