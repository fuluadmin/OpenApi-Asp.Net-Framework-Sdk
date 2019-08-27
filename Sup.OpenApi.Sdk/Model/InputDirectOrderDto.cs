using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 直充商品订单input dto
    /// </summary>
    public class InputDirectOrderDto
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

        /// <summary>
        /// 充值账号
        /// </summary>
        [JsonProperty("charge_account")]
        public string ChargeAccount { get; set; }

        /// <summary>
        /// 下单真实Ip，区域商品要传
        /// </summary>
        [JsonProperty("charge_ip")]
        public string ChargeIp { get; set; }

        /// <summary>
        /// 充值密码，部分游戏类要传
        /// </summary>
        [JsonProperty("charge_password")]
        public string ChargePassword { get; set; }

        /// <summary>
        /// 充值游戏名称
        /// </summary>
        [JsonProperty("charge_game_name")]
        public string ChargeGameName { get; set; }

        /// <summary>
        /// 充值游戏角色
        /// </summary>
        [JsonProperty("charge_game_role")]
        public string ChargeGameRole { get; set; }

        /// <summary>
        /// 充值游戏区
        /// </summary>
        [JsonProperty("charge_game_region")]
        public string ChargeGameRegion { get; set; }

        /// <summary>
        /// 充值游戏服
        /// </summary>
        [JsonProperty("charge_game_srv")]
        public string ChargeGameSrv { get; set; }

        /// <summary>
        /// 充值类型
        /// </summary>
        [JsonProperty("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 联系QQ
        /// </summary>
        [JsonProperty("contact_qq")]
        public string ContactQq { get; set; }
    }
}