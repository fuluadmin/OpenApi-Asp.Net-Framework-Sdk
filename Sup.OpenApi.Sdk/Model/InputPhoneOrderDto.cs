using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 话费订单input dto
    /// </summary>
    public class InputPhoneOrderDto
    {
        /// <summary>
        /// 充值手机号
        /// </summary>
        [JsonProperty("charge_phone")]
        public string ChargePhone { get; set; }

        /// <summary>
        /// 充值数额
        /// </summary>
        [JsonProperty("charge_value")]
        public decimal ChargeValue { get; set; }

        /// <summary>
        /// 外部订单号（应用订单号）
        /// </summary>
        [JsonProperty("customer_order_no")]
        public string CustomerOrderNo { get; set; }
    }
}
