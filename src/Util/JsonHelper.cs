using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class JsonHelper
    {
        #region Method

        /// <summary>
        /// 类对像转换成json格式
        /// </summary> 
        /// <returns></returns>
        public static string ToJson(object t)
        {
            return JsonConvert.SerializeObject(
                t,
                Formatting.None,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include });
        }

        /// <summary>
        /// 类对像转换成json格式
        /// </summary>
        /// <param name="t"></param>
        /// <param name="HasNullIgnore">是否忽略NULL值</param>
        /// <returns></returns>
        public static string ToJson(object t, bool HasNullIgnore)
        {
            if (HasNullIgnore)
                return JsonConvert.SerializeObject(
                    t,
                    Formatting.None,
                    new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            else
                return ToJson(t);
        }

        /// <summary>
        /// json格式转换
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="strJson"></param>
        /// <returns></returns>
        public static T FromJson<T>(string strJson) where T : class
        {
            if (!strJson.IsNullOrEmpty()) return JsonConvert.DeserializeObject<T>(strJson);
            return null;
        }

        /// <summary>
        /// 返回实体对象的格式化的JSON字符串
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static string ToJsonFormatString(object t)
        {
            var orgString = ToJson(t);
            return FormatJsonString(orgString);
        }

        /// <summary>
        /// 格式化字符串为json格式字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string FormatJsonString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return str;

            //格式化json字符串
            var sr = new StringReader(str);
            var jtr = new JsonTextReader(sr);
            var jSerializer = new JsonSerializer();
            var obj = jSerializer.Deserialize(jtr);
            if (obj != null)
            {
                var textWriter = new StringWriter();
                var jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                jSerializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }
        #endregion
    }
}
