using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace WinForm
{
    public partial class CreateInterfaceSign : Form
    {
        public CreateInterfaceSign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_msg.AppendText(System.Environment.NewLine+"开始签名" + System.Environment.NewLine);
                
                txt_sign.Text = "";
                if (!JudgeInput()) return;

                RequestCommon request = new RequestCommon();
                request.app_key = txt_key.Text.Trim();
                request.format = txt_format.Text.Trim();
                request.method = txt_method.Text.Trim();
                request.timestamp = txt_timestamp.Text.Trim();
                request.app_secret = txt_secret.Text.Trim();

                txt_sign.Text = Sign.CreateSign(request, rtb_v_data.Text.Trim());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rtb_msg.AppendText("签名结束"+System.Environment.NewLine);
            }
        }

        private bool JudgeInput()
        {
            if (string.IsNullOrWhiteSpace(txt_format.Text))
            {
                MessageBox.Show("format IsNullOrWhiteSpace");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_key.Text))
            {
                MessageBox.Show("key IsNullOrWhiteSpace");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_method.Text))
            {
                MessageBox.Show("method IsNullOrWhiteSpace");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_timestamp.Text))
            {
                MessageBox.Show("timestamp IsNullOrWhiteSpace");
                return false;
            }

            if (string.IsNullOrWhiteSpace(rtb_v_data.Text))
            {
                MessageBox.Show("v_data IsNullOrWhiteSpace");
                return false;
            }

            return true;
        }

        private void cb_useCurrentDateTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_useCurrentDateTime.Checked)
            {
                txt_timestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else
            {
                txt_timestamp.Text = "";
            }
        }

        private void CreateInterfaceSign_Load(object sender, EventArgs e)
        {
            txt_timestamp.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            cb_useCurrentDateTime.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_url.Text = "http://localhost:19029";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_url.Text = "http://192.168.23.11:6031";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_url.Text = "请手动填充";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_result.Text = "";
                if (!JudgeInput())
                    return;
                if(string.IsNullOrWhiteSpace(txt_url.Text))
                {
                    MessageBox.Show("请求url不能为空");
                    return;
                }
                if(!txt_url.Text.Trim().StartsWith("http"))

                {
                    MessageBox.Show("请输入正确url");
                    return;
                }
                RequestCommon request = new RequestCommon();
                request.app_key = txt_key.Text.Trim();
                request.format = txt_format.Text.Trim();
                request.method = txt_method.Text.Trim();
                request.timestamp = txt_timestamp.Text.Trim();
                request.app_secret = txt_secret.Text.Trim();

                txt_sign.Text = Sign.CreateSign(request, rtb_v_data.Text.Trim());
                string para = string.Format("/InterfaceReceive.ashx?app_key={0}&format={1}&method={2}&sign={3}&timestamp={4}",
                    request.app_key,
                    request.format, 
                    request.method,
                    txt_sign.Text.Trim(),
                    System.Web.HttpUtility.UrlEncode(request.timestamp));
               
                string url = txt_url.Text + para;
                rtb_result.AppendText("post url:" + url);
                var result=PostHelper.PostRemote(url, "v_data=" + rtb_v_data.Text.Trim(), "application/x-www-form-urlencoded","utf-8");
                rtb_result.AppendText(System.Environment.NewLine);
                rtb_result.AppendText(result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }

    public  class RequestCommon
    {

        /// <summary>
        /// WMS相关的业务接口名称
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 应用接入时的appkey
        /// </summary>
        public string app_key { get; set; }
        /// <summary>
        /// 根据url和密钥计算的结果
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// content格式，可选值:json
        /// </summary>
        public string format { get; set; }
        /// <summary>
        /// 时间戳，格式为yyyy-mm-dd HH:mm:ss，例如：2017-08-02 15:22:13。API服务端允许客户端请求时间误差为10分钟。
        /// </summary>
        public string timestamp { get; set; }
        /// <summary>
        /// 签名密钥
        /// </summary>
        public string app_secret { get; set; }
    }

    public static class Sign
    {
        public static string CreateSign(RequestCommon request,string v_data)
        {
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("method", request.method);
            parameters.Add("app_key", request.app_key);
            parameters.Add("format", request.format);
            parameters.Add("timestamp", request.timestamp);

            return CreateSign(parameters, request.app_secret, v_data);
        }

        /// <summary>
        /// 制作签名
        /// </summary>
        /// <param name="parameters">加密参数字典集合数据</param>
        /// <param name="secret">签名密匙</param>
        /// <param name="data">主体数据</param>
        /// <returns>签名</returns>
        public static string CreateSign(IDictionary<string, string> parameters, string secret, string data)
        {
            //第一步：对字典集合key进行排序

            //将元素复制到sorteddictionary中
            IDictionary<string, string> sortParam = new SortedDictionary<string, string>(parameters);
            IEnumerator<KeyValuePair<string, string>> dem = sortParam.GetEnumerator();

            //第二步：把参数名和参数值串在一起
            StringBuilder query = new StringBuilder(secret);
            while (dem.MoveNext())
            {
                string demKey = dem.Current.Key;
                string demValue = dem.Current.Value;
                if (demKey.Equals("sign"))
                {
                    continue; // 签名时不计算sign本身
                }
                else
                {
                    if (!string.IsNullOrEmpty(demKey) && !string.IsNullOrEmpty(demValue))
                    {
                        query.Append(demKey).Append(demValue);
                    }
                }
            }

            //将发送的数据添加到签名中
            query.Append(data);

            query.Append(secret);

            //第三步：使用md5加密
            MD5 md5 = MD5.Create();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(query.ToString()));
            md5.Clear();

            //第四步：把二进制转换为大写的16进制
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string hex = bytes[i].ToString("X");
                if (hex.Length == 1)
                {
                    result.Append("0");
                }
                result.Append(hex);
            }
            return result.ToString();
        }
    }
}
