using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 商品信息input dto
    /// </summary>
    public class InputProductDto
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }
    }
}
