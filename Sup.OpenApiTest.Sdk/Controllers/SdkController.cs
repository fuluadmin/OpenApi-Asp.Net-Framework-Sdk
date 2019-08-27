
using Sup.OpenApi.Sdk;
using Sup.OpenApi.Sdk.Common;
using Sup.OpenApi.Sdk.Model;
using Sup.OpenApiTest.Sdk.Models;
using System.Configuration;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Sup.OpenApiTest.Sdk.Controllers
{
    /// <summary>
    /// 演示SDK在项目中使用的方式
    /// </summary>
    [RoutePrefix("api/sdk")]
    public class SdkController: BaseController
    {
        private readonly string _url = ConfigurationManager.AppSettings["Url"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _sysSecret = ConfigurationManager.AppSettings["SysSecret"];

        private  IDefaultOpenApiClient _defaultOpenApiClient;

        /// <summary>
        /// 异步获得用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UserInfoGetAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> UserInfoGetAsync([FromBody]InputUserDto request)
        {
            _defaultOpenApiClient=new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiUserInfoGet);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 获得用户信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UserInfoGet")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult UserInfoGet([FromBody]InputUserDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiUserInfoGet);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步获得商品信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductInfoGetAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> ProductInfoGetAsync([FromBody]InputProductDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiGoodsGet);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 获得商品信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductInfoGet")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult ProductInfoGet([FromBody]InputProductDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiGoodsGet);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步获得商品模板信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductTemplateGetAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> ProductTemplateGetAsync([FromBody]InputProductTemplateDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiGoodsTemplateGet);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 获得商品模板信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ProductTemplateGet")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult ProductTemplateGet([FromBody]InputProductTemplateDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiGoodsTemplateGet);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步直充下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DirectOrderAddAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> DirectOrderAddAsync([FromBody]InputDirectOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiDirectOrderAdd);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 直充下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DirectOrderAdd")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult DirectOrderAdd([FromBody]InputDirectOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiDirectOrderAdd);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步话费下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PhoneOrderAddAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> PhoneOrderAddAsync([FromBody]InputPhoneOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiPhoneOrderAdd);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 话费下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PhoneOrderAdd")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult PhoneOrderAdd([FromBody]InputPhoneOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiPhoneOrderAdd);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步流量下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TrafficOrderAddAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> TrafficOrderAddAsync([FromBody]InputTrafficOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiTrafficOrderAdd);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 流量下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TrafficOrderAdd")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult TrafficOrderAdd([FromBody]InputTrafficOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiTrafficOrderAdd);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步卡密下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CardOrderAddAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> CardOrderAddAsync([FromBody]InputCardOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiCardOrderAdd);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 卡密下单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CardOrderAdd")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult CardOrderAdd([FromBody]InputCardOrderDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiCardOrderAdd);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 异步订单查单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("OrderInfoGetAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> OrderInfoGetAsync([FromBody]InputOrderGetDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiOrderGet);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// 订单查单
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("OrderInfoGet")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult OrderInfoGet([FromBody]InputOrderGetDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiOrderGet);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }


        /// <summary>
        /// 异步IP归属地查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MatchFuluPhoneAsync")]
        [ResponseType(typeof(OutputResponseDto))]
        public async Task<IHttpActionResult> MatchFuluPhoneAsync([FromBody] InputMatchPhoneProductListDto request)
        {
            _defaultOpenApiClient =
                new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiOrderGet);
            _defaultOpenApiClient.SetBizObject(request);
            var resultHtml = await _defaultOpenApiClient.ExcuteAsync();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }

        /// <summary>
        /// IP归属地查询
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("MatchFuluPhone")]
        [ResponseType(typeof(OutputResponseDto))]
        public IHttpActionResult MatchFuluPhone([FromBody]InputMatchPhoneProductListDto request)
        {
            _defaultOpenApiClient = new DefaultOpenApiClient(_url, _appKey, _sysSecret, ApiGlobalConst.MethodConst.OpenApiOrderGet);
            _defaultOpenApiClient.SetBizContent(request.ToJson());
            var resultHtml = _defaultOpenApiClient.Excute();
            var result = resultHtml.FromJson<OutputResponseDto>();
            return Json(result);
        }
    }
}