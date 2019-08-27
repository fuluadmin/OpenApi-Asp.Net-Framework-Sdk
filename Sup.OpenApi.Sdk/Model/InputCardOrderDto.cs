using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 卡密订单input dto
    /// </summary>
    public class InputCardOrderDto
    {
        /// <summary>
        /// 外部订单号（应用订单号）
        /// </summary>
        [JsonProperty("customer_order_no")]
        public string CustomerOrderNo { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonProperty("buy_num")]
        public int BuyNum { get; set; }
    }
}
