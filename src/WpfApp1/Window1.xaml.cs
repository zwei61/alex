using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    [MultipScreen(1, WindowStartupLocationInScreen.CenterScreen)]
    public partial class Window1 : Window
    {
        private Window1DataContextModel _str { get; set; }
        public Window1(Window1DataContextModel str)
        {
            _str = str;
            InitializeComponent();


            txtHHName.Content = $"{_str.HHName}";
            txtContract.Content = $"合同号：{_str.ContractCode}";
            txtAddress.Content = $"地址：{_str.Address}";
            orderItem_list.ItemsSource = _str.Results;
            //

            //StringBuilder sbMsg = new StringBuilder();
            //for (int i = 0; i < 100; i++)
            //{
            //    sbMsg.Append($"{i.ToString()}\r\n");
            //}
            //message.Text = sbMsg.ToString();
        }

        public  void Animation(int TotalCount, DependencyObject obj)
        {
            var scrollViewer = FindVisualChild<ScrollViewer>(obj);
            Storyboard storyboard = new Storyboard();
            TimeSpan ts = new TimeSpan(0, 0, 1);
            double end = 2000;//滚动距离，可根据数据源个数调整
            DoubleAnimation TopToButtomAnimation = new DoubleAnimation();
            TopToButtomAnimation.EasingFunction = new SineEase { EasingMode = EasingMode.EaseOut };
            TopToButtomAnimation.From = 0;
            TopToButtomAnimation.To = end;
            TopToButtomAnimation.Duration = new Duration(ts);
            TopToButtomAnimation.AutoReverse = true;
            TopToButtomAnimation.SpeedRatio = 1;
            storyboard.Duration = new Duration(TimeSpan.FromSeconds(1));
            storyboard.Children.Add(TopToButtomAnimation);
            Storyboard.SetTarget(TopToButtomAnimation, scrollViewer);
            Storyboard.SetTargetName(TopToButtomAnimation, scrollViewer.Name);
            Storyboard.SetTargetProperty(TopToButtomAnimation, new PropertyPath(ScrollViewerBehavior.VerticalOffsetProperty));
            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.Begin();

        }


        private  T FindVisualChild<T>(DependencyObject obj) where T : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is T)
                    return (T)child;
                else
                {
                    T childOfChild = FindVisualChild<T>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private void Scroll_Click(object sender, RoutedEventArgs e)
        {
            //Animation(100, this.ScrollViewertest);
            //Animation(orderItem_list.Items.Count, this.orderItem_list);
            if (orderItem_list.Items.Count > 0)
            {
                var border = VisualTreeHelper.GetChild(orderItem_list, 0) as Decorator;
                if (border != null)
                {
                    var scroll = border.Child as ScrollViewer;
                    if (scroll != null) scroll.ScrollToEnd();
                }
            }
        }
    }

    public class Window1DataContextModel : NotificationObject
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

        public ObservableCollection<Window1ResultModel> results;
        public ObservableCollection<Window1ResultModel> Results
        {
            get => results; set { results = value; RaisePropertyChanged("Results"); }
        }
    }

    public class Window1ResultModel
    {
        public string SkuNo { get; set; }

        public string SkuName { get; set; }

        public int Amount { get; set; }

        public string StatusName { get; set; }
    }
}
