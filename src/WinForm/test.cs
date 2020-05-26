using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = FuncTest((companyId) =>
            {
                return HandleInfo(companyId);
            });
        }

        public string FuncTest(Func<int,string> func)
        {
            StringBuilder sb = new StringBuilder();
            for (int i= 1; i < 3; i++)
            {
                sb.Append(func(i));
            }
            return sb.ToString();
        }

        public string HandleInfo(int companyId)
        {
            return "test:" + companyId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_msg.Clear();
                StringBuilder sb = new StringBuilder();
                var para = new PDAOtherSearchService.OtherSearchM()
                {
                    WarehouseId = 10,
                    WarehouseName = "北京仓",
                    SqlWhere = " AND WarehouseID=10 AND (CommodityCode ='1000002168')"
                };
                para.Key = CommunicateEncryptC.GetMd5<PDAOtherSearchService.OtherSearchM>(para, "123456");
                var service = new PDAOtherSearchService.OtherSearchServiceSoapClient();
                string[] ObjectList = { "批次号", "库存类型", "库存数", "占用数", "材料编码", "材料名称", "材料条码", "公司", "货位号", "货位类型" };
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var result = service.Execup_SelStoragePDA(para);
                sw.Stop();
                sb.Append("用时："+sw.Elapsed.TotalMilliseconds+"毫秒");
                sb.AppendLine();
                sb.Append(DataTableToString(result, ObjectList));
                rtb_msg.AppendText(sb.ToString());
            }
            catch(Exception ex)
            {
                rtb_msg.AppendText("异常："+ ex.Message);
            }
        }

        /// <summary>
        /// DataTable格式化成目标字符串
        /// </summary>
        /// <param name="dt">SQL查询到的数据</param>
        /// <returns></returns>
        private string DataTableToString(DataTable dt, string[] ObjectList)
        {
            StringBuilder sb = new StringBuilder();

            if (dt.Rows.Count > 0)
            {
                string prefix = String.Empty;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        string temp_value = dt.Rows[i][j].ToString();
                        string col_name = dt.Columns[j].ColumnName;
                        if (col_name == "考点")
                        {
                            prefix = temp_value;
                        }
                        if (temp_value != String.Empty)
                        {
                            if (IsContain(col_name, ObjectList))
                            {
                                sb.Append(prefix);
                                sb.Append("::");
                                sb.Append(col_name);
                                sb.Append("=");
                                sb.Append(temp_value);
                                sb.Append("\n");
                            }
                            else
                            {
                                sb.Append(col_name);
                                sb.Append("=");
                                sb.Append(temp_value);
                                sb.Append("\n");
                            }
                        }
                    }
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 判断字符串是否在数组中
        /// </summary>
        /// <param name="item">字符串</param>
        /// <param name="MesKeyList">字符串列表</param>
        /// <returns>存在返回True</returns>
        private bool IsContain(string item, string[] TestList)
        {
            foreach (string key in TestList)
            {
                if (key == item)
                {
                    return true;
                }
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<TestWhile> testList = new List<TestWhile>();
            testList.Add(new TestWhile() { name="aa",flag=false});
            testList.Add(new TestWhile() { name = "aa", flag = false });
            testList.Add(new TestWhile() { name = "aa", flag = false });
            testList.Add(new TestWhile() { name = "bb", flag = false });
            testList.Add(new TestWhile() { name = "bb", flag = false });
            testList.Add(new TestWhile() { name = "bb", flag = false });
            int i = 0;
            while(testList.Where(x=>x.flag==false).Any())
            {
                testList.Where(x => x.flag == false && x.name=="aa").ToList().ForEach(x=>{ x.flag = true; });
                if(i==1)
                {
                    testList.Where(x => x.flag == false && x.name == "bb").ToList().ForEach(x => { x.flag = true; });
                }
                i++;
            }
            MessageBox.Show("end");
        }
    }

    public class CommunicateEncryptC
    {
        public static string GetMd5<T>(T obj, string key)
        {
            //string xmlStr = XmlSerializerC.ScriptSerializeToXML(obj);

            string xmlStr = key;
            Type t = typeof(T);
            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo info in properties)
            {
                //if (info.PropertyType.Name != "DataTable")
                xmlStr += "name=" + info.Name + ";" + "type=" + info.PropertyType.Name + ";value=" + GetObjectPropertyValue<T>(obj, info.Name);
            }

            if (xmlStr.Length > 200)
            {
                xmlStr = xmlStr.Substring(0, 200);
            }

            return MD5C.UserMd5(xmlStr);
        }
        /// <summary>
        /// C#利用反射获取对象属性值  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="propertyname"></param>
        /// <returns></returns>
        public static string GetObjectPropertyValue<T>(T t, string propertyname)
        {
            Type type = typeof(T);

            PropertyInfo property = type.GetProperty(propertyname);

            if (property == null) return string.Empty;

            object o = property.GetValue(t, null);

            if (o == null) return string.Empty;

            return o.ToString();
        }
    }

    public class MD5C
    {

        /// <summary>
        /// MD5 16位加密
        /// </summary>
        /// <param name="ConvertString"></param>
        /// <returns></returns>
        public static string GetMd5Str(string ConvertString)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        /// <summary>
        /// MD5　32位加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string UserMd5(string str)
        {
            //MD5 md5 = new MD5CryptoServiceProvider();
            //byte[] bytResult = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(str));
            //string strResult = BitConverter.ToString(bytResult);
            //return strResult;
            string cl = str;
            string pwd = "";
            MD5 md5 = MD5.Create();//实例化一个md5对像
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符 

                pwd = pwd + s[i].ToString("X");

            }
            return pwd;
        }

    }

    public class TestWhile
    {
        public string name { get; set; }

        public bool flag { get; set; }
    }
}
