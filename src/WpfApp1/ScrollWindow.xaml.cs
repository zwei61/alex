using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// ScrollWindow.xaml 的交互逻辑
    /// </summary>
    [MultipScreen(1, WindowStartupLocationInScreen.CenterScreen)]
    public partial class ScrollWindow : Window
    {
        private System.Timers.Timer _timer;
        private ScrollWindowDataContextModel _data;
        private int _index;
        private int PageSize = 21;
        private double Interval = 5000;
        private int pageCount;
        private Storyboard _storyboard;

        private int typeBatch = 1;
        public ScrollWindow()
        {
            AutoScreen();//需要设置高度、宽度才会遵循MultipScreen的指定显示屏显示
            //this.Width = 800;
            //this.Height = 500;
            InitializeComponent();

            this.KeyDown += ScrollWindow_KeyDown;

            _data = GetAllData();
            txtHHName.Content = $"{_data.HHName}";
            txtContract.Content = $"合同号：{_data.ContractCode}";
            txtAddress.Content = $"地址：{_data.Address}";
        }

        private void ScrollWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)//Esc键  
            {
                this.Close();
            }
        }

        private void ScrollWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //AutoScreen();


            if (_timer == null)
            {
                _storyboard = (Storyboard)this.FindResource("storyboard");

                System.Threading.Tasks.Task.Factory.StartNew(() =>
                {
                    pageCount = (_data.Results.Count() + PageSize - 1) / PageSize;
                    _index= 1;
                    Dispatcher.BeginInvoke(new Action(() =>
                    {
                        stackPanel.RenderTransform = new TranslateTransform(0, 0);
                    }));
                    ShowData();
                });

                _timer = new System.Timers.Timer();
                _timer.Interval = Interval;
                _timer.Elapsed += Action;
                _timer.Start();
            }
        }

        private void AutoScreen()
        {
            this.WindowState = System.Windows.WindowState.Normal;
            this.WindowStyle = System.Windows.WindowStyle.None;
            this.ResizeMode = System.Windows.ResizeMode.NoResize;

            //this.Topmost = true;

            if (System.Windows.Forms.Screen.AllScreens.Where(o => o.Primary == false).Count() == 0)
            {
                this.Left = 0.0;
                this.Top = 0.0;
                this.Width = System.Windows.SystemParameters.WorkArea.Width;//.PrimaryScreenWidth;
                this.Height = System.Windows.SystemParameters.WorkArea.Height;//.PrimaryScreenHeight;
            }
            else
            {
                var minorScreen = System.Windows.Forms.Screen.AllScreens.Where(o => o.Primary == false).First();
                this.Left = 0.0;
                this.Top = 0.0;
                var name = minorScreen.DeviceName;
                this.Width = minorScreen.WorkingArea.Width;
                this.Height = minorScreen.WorkingArea.Height;
            }
        }

        private ScrollWindowDataContextModel GetAllData(int type=0)
        {
            ScrollWindowDataContextModel allData = new ScrollWindowDataContextModel();
            allData.HHName = "赵四"; 
            allData.ContractCode = "1003175664863";
            allData.Address = "北京市大兴区旧宫镇 住总万科广场C座11层";
            List<WindowScrollResultModel> rList = new List<WindowScrollResultModel>();
            for (int i = 0; i <= 100; i++)
            {
                WindowScrollResultModel r = new WindowScrollResultModel()
                {
                    SkuNo = $"sku{i.ToString()}-{type}",
                    SkuName = $"sku{i.ToString()}-{type}",
                    Amount = i,
                    StatusName = i.ToString().Contains("3") ? "未拣货" : i % 2 == 0 ? "已拣货" : "已复核",
                };
                rList.Add(r);
            }
            allData.Results = new ObservableCollection<WindowScrollResultModel>(rList);
            return allData;
        }

        private void Action(object sender, ElapsedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                stackPanel.RenderTransform = new TranslateTransform(0, 0);
                _storyboard.Begin();
            }));

            _index++;
            if (_index > pageCount)
            {
                
                // 可以在这循环完一轮后重新加载数据
                _data = GetAllData(typeBatch);
                typeBatch++;

                _index = 1;
            }

            ShowData();
        }

        private void ShowData()
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                List<WindowScrollResultModel> dataList = GetPageData(_index);
                StringBuilder sbMsg = new StringBuilder();
                dataList.ForEach(x=> {
                    sbMsg.Append($"{x.SkuNo}     {x.SkuName}      {x.Amount}      {x.StatusName} \r\n");
                });
                //lab_text.Content = sbMsg.ToString() ;

                orderItem_list.ItemsSource = dataList;
            }));
        }

        private List<WindowScrollResultModel> GetPageData(int pageIndex)
        {
            if (_data != null)
            {
                return _data.Results.Skip((pageIndex - 1) * PageSize).Take(PageSize).ToList();
            }
            return null;
        }

        private void ScrollWindow_MouseEnter(object sender, MouseEventArgs e)
        {
            _timer.Stop();
        }

        private void ScrollWindow_MouseLeave(object sender, MouseEventArgs e)
        {
            _timer.Start();
        }

        private void ScrollWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();

                //AutoScreen();
            }
        }
    }

    public class ScrollWindowDataContextModel : NotificationObject
    {
        public string _HHName;
        public string HHName
        {
            get => _HHName; set { _HHName = value; RaisePropertyChanged("HHName"); }
        }

        public string _ContractCode;
        public string ContractCode
        {
            get => _ContractCode; set { _ContractCode = value; RaisePropertyChanged("ContractCode"); }
        }

        public string _Address;
        public string Address
        {
            get => _Address; set { _Address = value; RaisePropertyChanged("Address"); }
        }

        public ObservableCollection<WindowScrollResultModel> results;
        public ObservableCollection<WindowScrollResultModel> Results
        {
            get => results; set { results = value; RaisePropertyChanged("Results"); }
        }
    }

    public class WindowScrollResultModel
    {
        public string SkuNo { get; set; }

        public string SkuName { get; set; }

        public int Amount { get; set; }

        public string StatusName { get; set; }
    }
}
