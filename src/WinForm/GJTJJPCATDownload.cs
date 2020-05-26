using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace WinForm
{
    public partial class GJTJJPCATDownload : Form
    {
        public GJTJJPCATDownload()
        {
            InitializeComponent();
        }

        private void GJTJJPCATDownload_Load(object sender, EventArgs e)
        {
            cb_year.Items.Add(DateTime.Now.Year-1);
            cb_year.SelectedIndex = 0;
            filePath = AppDomain.CurrentDomain.BaseDirectory;
        }
        private string url = "";
        private string year = "";
        private string fileName = "pcatv.txt";
        private string filePath = "";//root

        public List<pcatv> pcatvList = new List<pcatv>();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                url = txt_url.Text;
                year = cb_year.SelectedItem.ToString();

                //DownP();
                //Thread th1 = new Thread(new ThreadStart(DownP));
                //th1.Start();

                Thread.Sleep(3000);

                //DownC();
                //Thread th2 = new Thread(new ThreadStart(DownC));
                //th2.Start();

                Thread.Sleep(3000);

                //Thread th = new Thread(new ThreadStart(DownA));
                //th.Start();

                Thread.Sleep(3000);
                //DownT();
                Thread th3 = new Thread(new ThreadStart(DownT));
                th3.Start();

                Thread.Sleep(3000);

                //Thread th4 = new Thread(new ThreadStart(DownV));
                //th4.Start();
                MessageBox.Show("下载完成");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownP()
        {
            var geturl = url+txt_p_url.Text.Replace( "{year}",year);
            var html = getPage(geturl);
            Regex re = new Regex("<a .*?href=['\"](.*?)['\"].*?>(.*?)<br/></a>");
            Match q = re.Match(html);
            while (q.Success)
            {
                pcatv p = new pcatv();
                p.flag = "p";
                p.level = 1;
                p.nextUrl= q.Groups[1].ToString();
                p.name= q.Groups[2].ToString();
                p.no = p.nextUrl.Replace(".html","0000000000");
                p.parentNo = "";
                pcatvList.Add(p);
                q = q.NextMatch();
            }
            CreateFile(pcatvList);
        }

        private void DownC()
        {
            pcatvList = ReadFile();
            pcatvList.RemoveAll(x=>x.level==2);
            var curl = txt_url.Text + year;
            var pList = Clone<pcatv>(pcatvList).Where(x => x.parentNo == "" && x.level == 1 && x.flag == "p" && !string.IsNullOrWhiteSpace(x.nextUrl));
            if (!pList.Any()) return;
            foreach(pcatv p in pList)
            {
                var ccurl = curl +"/"+ p.nextUrl;
                var html = getPage(ccurl);
                Regex re = new Regex("<a .*?href=['\"](.*?)['\"].*?>(.*?)</a></td><td><a .*?href=['\"].*?['\"].*?>(.*?)</a>");
                Match q = re.Match(html);
                while (q.Success)
                {
                    pcatv c = new pcatv();
                    c.flag = "c";
                    c.level = 2;
                    c.nextUrl = q.Groups[1].ToString();
                    c.name = q.Groups[3].ToString();
                    c.no = q.Groups[2].ToString();
                    c.parentNo = p.no;
                    pcatvList.Add(c);
                    q = q.NextMatch();
                }
            }
            CreateFile(pcatvList);
        }

        private void DownA()
        {
            pcatvList = ReadFile();
            pcatvList.RemoveAll(x => x.level == 3);
            var curl = txt_url.Text + year;
            var cList = Clone<pcatv>(pcatvList).Where(x => x.level == 2 && x.flag == "c" && !string.IsNullOrWhiteSpace(x.nextUrl));
            if (!cList.Any()) return;
            rtb_msg.AppendText("共：" + cList.Count() + "行 \n");
            foreach (pcatv c in cList)
            {
                rtb_msg.AppendText("/"+c.nextUrl+ "\n");
                var ccurl = curl + "/" + c.nextUrl;
                var html = getPage(ccurl);
                //无连接
                Regex re = new Regex(@"<tr class='countytr'><td>(\d+)</td><td>(.*?)</td></tr>");
                Match q = re.Match(html);
                while (q.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "a";
                    a.level = 3;
                    a.nextUrl = "";
                    a.name = q.Groups[2].ToString();
                    a.no = q.Groups[1].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q = q.NextMatch();
                }
               //有链接
                Regex re1 = new Regex("<a .*?href=['\"](.*?)['\"].*?>(.*?)</a></td><td><a .*?href=['\"].*?['\"].*?>(.*?)</a>");
                Match q1 = re1.Match(html);
                while (q1.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "a";
                    a.level = 3;
                    a.nextUrl = q1.Groups[1].ToString();
                    a.name = q1.Groups[3].ToString();
                    a.no = q1.Groups[2].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q1 = q1.NextMatch();
                }
            }
            CreateFile(pcatvList);
        }

        private void DownT()
        {
            pcatvList = ReadFile();
            pcatvList.RemoveAll(x => x.level == 4);
            var curl = txt_url.Text + year;
            var cArea = Clone<pcatv>(pcatvList).Where(x => x.level == 3 && x.flag == "a" && !string.IsNullOrWhiteSpace(x.nextUrl));
            if (!cArea.Any()) return;
            rtb_msg.AppendText("共：" + cArea.Count() + "行 \n");
            foreach (pcatv c in cArea)
            {
                rtb_msg.AppendText("/" + c.nextUrl + "\n");
                var ccurl = curl + "/"+c.no.Substring(0,2)+"/" + c.nextUrl;
                var html = getPage(ccurl);

                Regex re = new Regex(@"<tr class='towntr'><td>(\d+)</td><td>(.*?)</td></tr>");
                Match q = re.Match(html);
                while (q.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "t";
                    a.level = 4;
                    a.nextUrl = "";
                    a.name = q.Groups[2].ToString();
                    a.no = q.Groups[1].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q = q.NextMatch();
                }

                Regex re1 = new Regex("<a .*?href=['\"](.*?)['\"].*?>(.*?)</a></td><td><a .*?href=['\"].*?['\"].*?>(.*?)</a>");
                Match q1 = re1.Match(html);
                while (q1.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "t";
                    a.level = 4;
                    a.nextUrl = c.no.Substring(0, 2) + "/" + c.nextUrl.Substring(0,2)+"/"+q1.Groups[1].ToString();
                    a.name = q1.Groups[3].ToString();
                    a.no = q1.Groups[2].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q1 = q1.NextMatch();
                }
            }
            CreateFile(pcatvList);
        }

        private void DownV()
        {
            pcatvList = ReadFile();
            pcatvList.RemoveAll(x => x.level == 5);
            var curl = txt_url.Text + year;
            var cTown = Clone<pcatv>(pcatvList).Where(x => x.level == 4 && x.flag == "t" && !string.IsNullOrWhiteSpace(x.nextUrl));
            if (!cTown.Any()) return;
            rtb_msg.AppendText("共：" + cTown.Count() + "行 \n");
            foreach (pcatv c in cTown)
            {
                rtb_msg.AppendText("/" + c.nextUrl + "\n");
                var ccurl = curl + "/" + c.nextUrl;
                var html = getPage(ccurl);

                Regex re = new Regex(@"<tr class='villagetr'><td>(\d+)</td><td>(.*?)</td></tr>");
                Match q = re.Match(html);
                while (q.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "v";
                    a.level = 5;
                    a.nextUrl = "";
                    a.name = q.Groups[2].ToString();
                    a.no = q.Groups[1].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q = q.NextMatch();
                }

                Regex re1 = new Regex("<a .*?href=['\"](.*?)['\"].*?>(.*?)</a></td><td><a .*?href=['\"].*?['\"].*?>(.*?)</a>");
                Match q1 = re1.Match(html);
                while (q1.Success)
                {
                    pcatv a = new pcatv();
                    a.flag = "v";
                    a.level = 5;
                    a.nextUrl = q1.Groups[1].ToString();
                    a.name = q1.Groups[3].ToString();
                    a.no = q1.Groups[2].ToString();
                    a.parentNo = c.no;
                    pcatvList.Add(a);
                    q1 = q1.NextMatch();
                }
            }
            CreateFile(pcatvList);
        }

        public static List<T> Clone<T>(object List)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, List);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as List<T>;
            }
        }

        public void CreateFile(List<pcatv> pcatvList)
        {
            var jsonStr = JsonHelper.ToJson(pcatvList);
            string file = filePath + "\\" + fileName;
            if (File.Exists(file))
                File.Delete(file);
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(jsonStr);
                sw.Close();
            }
        }

        public List<pcatv> ReadFile()
        {
            string file = filePath + "\\" + fileName;
            StreamReader sr = new StreamReader(file, Encoding.Default);
            StringBuilder sb = new StringBuilder();
            string content;
            while ((content = sr.ReadLine()) != null)
            {
                sb.Append(content);
            }
            return JsonHelper.FromJson<List<pcatv>>( sb.ToString());
        }

        public string getPage(string url)
        {
            try
            {
                string content = "";
                WebClient myWebClient = new WebClient();
                Stream readStream = myWebClient.OpenRead(url);
                StreamReader sr = new StreamReader(readStream, System.Text.Encoding.GetEncoding("gb2312"));
                Char[] read = new Char[256];
                int count = sr.Read(read, 0, 256);
                while (count > 0)
                {
                    string str = new string(read, 0, count);
                    content = content + str;
                    count = sr.Read(read, 0, 256);
                }
                return content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
    }

    [Serializable]
    public class pcatv
    {
        public string no { get; set; }
        public string parentNo { get; set; }

        public string name { get; set; }

        public int level { get; set; }

        public string flag { get; set; }

        public string nextUrl { get; set; }
    }
}
