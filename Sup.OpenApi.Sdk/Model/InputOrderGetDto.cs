using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 订单查单input dto
    /// </summary>
    public class InputOrderGetDto
    {
        /// <summary>
        /// 外部订单号，每次请求必须唯一	
        /// </summary>
        [JsonProperty("customer_order_no")]
        public string CustomerOrderNo { get; set; }
    }
}
