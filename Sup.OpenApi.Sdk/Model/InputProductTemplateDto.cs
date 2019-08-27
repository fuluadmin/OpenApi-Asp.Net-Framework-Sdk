using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 商品模板信息input dto
    /// </summary>
    public class InputProductTemplateDto
    {
        /// <summary>
        /// 商品模板编号
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }
    }
}
