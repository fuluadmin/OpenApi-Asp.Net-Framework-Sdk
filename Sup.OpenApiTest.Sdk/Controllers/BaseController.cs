using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Http;

namespace Sup.OpenApiTest.Sdk.Controllers
{
    /// <summary>
    /// 基类
    /// </summary>
    public class BaseController : ApiController
    {
        /// <summary>
        /// 重写梳理时间日期格式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        protected new System.Web.Http.Results.JsonResult<T> Json<T>(T content)
        {
            return base.Json<T>(
                content
                , new Newtonsoft.Json.JsonSerializerSettings { DateFormatString = "yyyy-MM-dd HH:mm:ss" }
                , Encoding.UTF8);
        }
    }
}