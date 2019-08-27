using System;
using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 公共请求参数input dto
    /// </summary>
    public class InputRequestDto
    {
        /// <summary>
        /// 开放平台分配给商户的AppKey
        /// </summary>
        [JsonProperty("app_key")]
        public string AppKey { get; set; }
        /// <summary>
        /// 接口方法名称
        /// </summary>
        [JsonProperty("method")]
        public string Method { get; set; }

        /// <summary>
        /// 时间戳，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// 调用的接口版本
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; } = "2.0";

        /// <summary>
        /// 目前仅支持json
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; } = "json";

        /// <summary>
        /// 请求使用的编码格式，如utf-8
        /// </summary>
        [JsonProperty("charset")]
        public string Charset { get; set; } = "utf-8";

        /// <summary>
        /// 签名加密类型，目前仅支持md5
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; } = "md5";
        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 应用授权auth_token
        /// </summary>
        [JsonProperty("app_auth_token")]
        public string AppAuthToken { get; set; } = "";

        /// <summary>
        /// 请求参数集合
        /// </summary>
        [JsonProperty("biz_content")]
        public string BizContent { get; set; }
    }
}
