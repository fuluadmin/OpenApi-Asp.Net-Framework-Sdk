using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sup.OpenApi.Sdk.Core.Encrypt;
using Sup.OpenApi.Sdk.Core.Http;
using Sup.OpenApi.Sdk.Model;

namespace Sup.OpenApi.Sdk
{
    /// <summary>
    /// 默认OpenApi客户请求接口
    /// </summary>
    public interface IDefaultOpenApiClient
    {
        /// <summary>
        /// 设置业务参数
        /// </summary>
        /// <param name="bizContent"></param>
        void SetBizContent(string bizContent);

        /// <summary>
        /// 设置业务参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bizModel"></param>
        void SetBizObject<T>(T bizModel);

        /// <summary>
        /// 执行请求，同步方法
        /// </summary>
        /// <returns></returns>
        string Excute();

        /// <summary>
        /// 执行请求，异步方法
        /// </summary>
        /// <returns></returns>
        Task<string> ExcuteAsync();
    }

    /// <summary>
    /// 默认OpenApi客户请求实现
    /// </summary>
    public class DefaultOpenApiClient : IDefaultOpenApiClient
    {
        /// <summary>
        /// 接口地址
        /// </summary>
        private readonly string _url;
        /// <summary>
        /// 商户AppKey
        /// </summary>
        private readonly string _appKey;
        /// <summary>
        /// 应用秘钥
        /// </summary>
        private readonly string _sysSecret;
        /// <summary>
        /// 接口方法名称
        /// </summary>
        private readonly string _method;
        /// <summary>
        /// 业务参数
        /// </summary>
        private string _bizContent;
        /// <summary>
        /// http请求
        /// </summary>
        private readonly IFuluClient _fuluClient;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="url"></param>
        /// <param name="appKey"></param>
        /// <param name="sysSecret"></param>
        /// <param name="method"></param>
        public DefaultOpenApiClient(string url, string appKey, string sysSecret, string method)
        {
            _url = url;
            _appKey = appKey;
            _sysSecret = sysSecret;
            _method = method;

            _fuluClient=new FuluClient(url);
        }

        /// <summary>
        /// 设置业务参数
        /// </summary>
        /// <param name="bizContent"></param>
        public void SetBizContent(string bizContent)
        {
            _bizContent = bizContent;
        }

        /// <summary>
        /// 设置业务参数
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bizModel"></param>
        public void SetBizObject<T>(T bizModel)
        {
            _bizContent = bizModel.ToJson();
        }

        /// <summary>
        /// 执行请求，同步方法
        /// </summary>
        /// <returns></returns>
        public string Excute()
        {
            InputRequestDto dto =new InputRequestDto();
            dto.AppKey = _appKey;
            dto.Method = _method;
            dto.BizContent = _bizContent;

            //计算签名
            var dictionary = dto.ToJson().FromJson<Dictionary<string, string>>();
            dictionary.Remove("sign");
            var signJson = dictionary.ToJson();
            var data = signJson.ToCharArray();
            Array.Sort(data);
            var inputSignOriginalStr = new string(data) + _sysSecret;
            var sign = Md5Encrypt.GetMd5(inputSignOriginalStr).ToLower();
            dto.Sign = sign;

            var value = _fuluClient.Send(dto.ToJson());
            return value;
        }

        /// <summary>
        /// 执行请求，异步方法
        /// </summary>
        /// <returns></returns>
        public async Task<string> ExcuteAsync()
        {
            InputRequestDto dto = new InputRequestDto();
            dto.AppKey = _appKey;
            dto.Method = _method;
            dto.BizContent = _bizContent;

            //计算签名
            var dictionary = dto.ToJson().FromJson<Dictionary<string, string>>();
            dictionary.Remove("sign");
            var signJson = dictionary.ToJson();
            var data = signJson.ToCharArray();
            Array.Sort(data);
            var inputSignOriginalStr = new string(data) + _sysSecret;
            var sign = Md5Encrypt.GetMd5(inputSignOriginalStr).ToLower();
            dto.Sign = sign;

            var value =await _fuluClient.SendAsync(dto.ToJson());
            return value;
        }
    }
}