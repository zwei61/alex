using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class PostHelper
    {
        public static string PostRemote(string url, string para, bool isGzip, string contentType = "application/json", string charset = "utf-8")
        {
            return PostRemote(url, para, null, isGzip, contentType, charset);
        }

        public static string PostRemote(string url, string para, string contentType = "application/json", string charset = "utf-8")
        {
            return PostRemote(url, para, null, false, contentType, charset);
        }
        public static string PostRemote(string url, string para, List<KeyValuePair<string, string>> header, bool isGzip = false, string contentType = "application/json", string charset = "utf-8")
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", contentType);
                webClient.Headers.Add("charset", charset);
                if (header != null && header.Any())
                {
                    foreach (KeyValuePair<string, string> k in header)
                    {
                        webClient.Headers.Add(k.Key, k.Value);
                    }
                }
                Encoding enc = Encoding.GetEncoding(charset);
                byte[] postData = enc.GetBytes(para);
                byte[] responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流  
                if (isGzip)
                {
                    MemoryStream ms = new MemoryStream(responseData);
                    MemoryStream msTemp = new MemoryStream();
                    int count = 0;
                    GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress);
                    byte[] buf = new byte[1000];

                    while ((count = gzip.Read(buf, 0, buf.Length)) > 0)
                    {
                        msTemp.Write(buf, 0, count);
                    }
                    return enc.GetString(msTemp.ToArray());
                }
                else
                    return enc.GetString(responseData);//解码
            }
            catch (WebException ex)
            {
                //response 400 时有错误对象返回的，在这里捕捉返回
                var stream = ex.Response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                return text;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string GetRemote(string url)
        {
            return GetRemote(url, null, false, "application/json", "utf-8");
        }

        public static string GetRemote(string url, bool isGzip = false, string contentType = "application/json", string charset = "utf-8")
        {
            return GetRemote(url, null, isGzip, contentType, charset);
        }

        public static string GetRemote(string url, List<KeyValuePair<string, string>> header, bool isGzip = false, string contentType = "application/json", string charset = "utf-8")
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", contentType);
            webClient.Headers.Add("charset", charset);
            if (header != null && header.Any())
            {
                foreach (KeyValuePair<string, string> k in header)
                {
                    webClient.Headers.Add(k.Key, k.Value);
                }
            }
            Encoding enc = Encoding.GetEncoding(charset);
            Byte[] responseData = webClient.DownloadData(url);
            if (isGzip)
            {
                MemoryStream ms = new MemoryStream(responseData);
                MemoryStream msTemp = new MemoryStream();
                int count = 0;
                GZipStream gzip = new GZipStream(ms, CompressionMode.Decompress);
                byte[] buf = new byte[1000];

                while ((count = gzip.Read(buf, 0, buf.Length)) > 0)
                {
                    msTemp.Write(buf, 0, count);
                }
                return enc.GetString(msTemp.ToArray());
            }
            else
                return enc.GetString(responseData);//解码
        }

        public static string DeleteRemote(string url, string para, List<KeyValuePair<string, string>> header, string contentType = "application/json", string charset = "utf-8")
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", contentType);
                webClient.Headers.Add("charset", charset);
                if (header != null && header.Any())
                {
                    foreach (KeyValuePair<string, string> k in header)
                    {
                        webClient.Headers.Add(k.Key, k.Value);
                    }
                }
                Encoding enc = Encoding.GetEncoding(charset);
                byte[] postData = enc.GetBytes(para);

                byte[] responseData = webClient.UploadData(url, "DELETE", postData);//得到返回字符流  

                return enc.GetString(responseData);//解码
            }
            catch (WebException ex)
            {
                //response 400 时有错误对象返回的，在这里捕捉返回
                var stream = ex.Response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                return text;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string PutRemote(string url, string para, List<KeyValuePair<string, string>> header, string contentType = "application/json", string charset = "utf-8")
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Headers.Add("Content-Type", contentType);
                webClient.Headers.Add("charset", charset);
                if (header != null && header.Any())
                {
                    foreach (KeyValuePair<string, string> k in header)
                    {
                        webClient.Headers.Add(k.Key, k.Value);
                    }
                }
                Encoding enc = Encoding.GetEncoding(charset);
                byte[] postData = enc.GetBytes(para);

                byte[] responseData = webClient.UploadData(url, "PUT", postData);//得到返回字符流  

                return enc.GetString(responseData);//解码
            }
            catch (WebException ex)
            {
                //response 400 时有错误对象返回的，在这里捕捉返回
                var stream = ex.Response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();
                return text;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
