using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    [MultipScreen( 0,  WindowStartupLocationInScreen.CenterScreen)]
    public partial class MainWindow : Window
    {
        private DataContextModel dataContext = new DataContextModel();
        public MainWindow()
        {
            InitializeComponent();

            //dataContext 界面使用对象 mvc;
            
            dataContext.dp_time = DateTime.Now.AddMonths(-1);
            this.DataContext = dataContext;

            txtValue.SetBinding(TextBox.TextProperty, new Binding("Value") { ElementName = "slider1" });
        }

        /// <summary>
        /// mvvm加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            lab_show.Content = dataContext.dpTime.ToShortDateString();
            List<ResultModel> rmList = new List<ResultModel>();
            rmList.Add(new ResultModel() { id = 22, name = "张三", sex = EnumSex.girl });
            rmList.Add(new ResultModel() { id = 33, name = "李四", sex = EnumSex.boy });
            rmList.Add(new ResultModel() { id = 44, name = "王二", sex = EnumSex.girl });
            rmList.Add(new ResultModel() { id = 55, name = "赵大", sex = EnumSex.boy });
            dataContext.Results = new ObservableCollection<ResultModel>(rmList); 
        }

        private void btn_Open_Click(object sender, RoutedEventArgs e)
        {
            Window1DataContextModel data = new Window1DataContextModel();
            data.HHName = "赵四";
            data.ContractCode = "1003175664863";
            data.Address = "北京市大兴区旧宫镇 住总万科广场C座11层";

            List<Window1ResultModel> rList = new List<Window1ResultModel>();
            for(int i = 0; i <= 100; i++)
            {
                Window1ResultModel r = new Window1ResultModel() {
                    SkuNo = $"sku{i.ToString()}",
                    SkuName = $"sku{i.ToString()}",
                    Amount = i,
                    StatusName = i.ToString().Contains("3")? "未拣货" : i % 2 == 0 ? "已拣货" : "已复核",
                };
                rList.Add(r);
            }
            data.Results = new ObservableCollection<Window1ResultModel>(rList);

            Window1 w = new Window1(data);
            //w.Show();
            MultipScreenManager.ShowInScreen(w);
        }

        private void btn_Scroll_Click(object sender, RoutedEventArgs e)
        {
            ScrollWindow w = new ScrollWindow();
            MultipScreenManager.ShowInScreen(w);
        }

        /// <summary>
        /// 普通加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btn_Search_Click(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine($"时间选择：{dataContext.dpTime.ToShortDateString()}");
        //    //dataContext.Results=
        //    List<ResultModel> rmList = new List<ResultModel>();
        //    rmList.Add(new ResultModel() { id=22,name="张三", sex = EnumSex.girl });
        //    rmList.Add(new ResultModel() { id = 33, name = "李四", sex = EnumSex.boy });
        //    rmList.Add(new ResultModel() { id = 44, name = "王二", sex = EnumSex.girl });
        //    rmList.Add(new ResultModel() { id = 55, name = "赵大", sex = EnumSex.boy });
        //    dp_list.ItemsSource = rmList;
        //}
    }

    public class DataContextModel: NotificationObject
    {
        public DateTime dpTime;
        public DateTime dp_time
        {
            get => dpTime; set { dpTime = value;RaisePropertyChanged("dp_time"); }
        }

        public ObservableCollection<ResultModel> results;
        public ObservableCollection<ResultModel> Results
        {
            get => results; set { results = value; RaisePropertyChanged("Results"); }
        }
    }

    public class ResultModel
    {
        public int id { get; set; }

        public string name{ get; set; }

        public EnumSex sex { get; set; }
    }

    public enum EnumSex
    {
        boy=0,
        girl=1
    }
}
