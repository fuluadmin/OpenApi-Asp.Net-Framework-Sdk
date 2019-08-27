using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Sup.OpenApi.Sdk.Core.Encrypt
{
    /// <summary>
    /// Md5加密
    /// </summary>
    public class Md5Encrypt
    {
        /// <summary>
        /// 获取Md5加密的字符串
        /// </summary>
        /// <param name="str">需要加密的字符串</param>
        /// <param name="encode">字符集格式</param>
        /// <returns></returns>
        public static string GetMd5(string str, Encoding encode = null)
        {
            if (encode == null) encode = Encoding.UTF8;
            var cl = str;
            var md5 = MD5.Create(); //实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            var s = md5.ComputeHash(encode.GetBytes(cl));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 
            return s.Aggregate("", (current, t) => current + t.ToString("x2"));
        }
    }
}
