using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 流量订单input dto
    /// </summary>
    public class InputTrafficOrderDto
    {
        /// <summary>
        /// 外部订单号（应用订单号）
        /// </summary>
        [JsonProperty("customer_order_no")]
        public string CustomerOrderNo { get; set; }

        /// <summary>
        /// 充值手机号
        /// </summary>
        [JsonProperty("charge_phone")]
        public string ChargePhone { get; set; }

        /// <summary>
        /// 充值数额（M）
        /// </summary>
        [JsonProperty("charge_value")]
        public decimal ChargeValue { get; set; }

        /// <summary>
        /// 流量性质 1:小时  2:日 3:7天 4:月 5:季度 6:半年 7:年
        /// </summary>
        [JsonProperty("packet_kind")]
        public int? PacketKind { get; set; }

    }
}
