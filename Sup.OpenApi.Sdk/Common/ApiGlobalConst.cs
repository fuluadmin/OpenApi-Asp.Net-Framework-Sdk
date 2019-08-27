using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sup.OpenApi.Sdk.Common
{
    /// <summary>
    /// 全局常量
    /// </summary>
    public class ApiGlobalConst
    {
        /// <summary>
        /// 接口method方法名称
        /// </summary>
        public class MethodConst
        {
            /// <summary>
            /// 获取商品信息接口method方法
            /// </summary>
            public static readonly string OpenApiGoodsGet = "fulu.goods.info.get";
            /// <summary>
            /// 获取商品模板信息接口method方法
            /// </summary>
            public static readonly string OpenApiGoodsTemplateGet = "fulu.goods.template.get";
            /// <summary>
            /// 获取用户信息接口method方法
            /// </summary>
            public static readonly string OpenApiUserInfoGet = "fulu.user.info.get";
            /// <summary>
            /// 直充下单接口method方法
            /// </summary>
            public static readonly string OpenApiDirectOrderAdd = "fulu.order.direct.add";
            /// <summary>
            /// 话费下单接口method方法
            /// </summary>
            public static readonly string OpenApiPhoneOrderAdd = "fulu.order.mobile.add";
            /// <summary>
            /// 流量下单接口method方法
            /// </summary>
            public static readonly string OpenApiTrafficOrderAdd = "fulu.order.data.add";
            /// <summary>
            /// 卡密下单接口method方法
            /// </summary>
            public static readonly string OpenApiCardOrderAdd = "fulu.order.card.add";
            /// <summary>
            /// 查单接口method方法
            /// </summary>
            public static readonly string OpenApiOrderGet = "fulu.order.info.get";

            /// <summary>
            /// 根据话费查询归属地和城市编码，面值，城市等信息
            /// </summary>
            public static readonly string OpenApiCheckPhone = "fulu.mobile.info.get";
        }
    }
}
