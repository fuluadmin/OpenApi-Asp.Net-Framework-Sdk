using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sup.OpenApi.Sdk.Model
{
    /// <summary>
    /// 手机号归属地input dto
    /// </summary>
    public class InputMatchPhoneProductListDto
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 面值
        /// </summary>
        [JsonProperty("face_value")]
        public decimal? FaceValue { get; set; }

    }
}
