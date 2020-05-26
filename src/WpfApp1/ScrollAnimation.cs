using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfApp1
{
    public class ScrollAnimation
    {
        public static void Animation(int TotalCount, DependencyObject obj)
        {
            var scrollViewer = FindVisualChild<ScrollViewer>(obj);
            Storyboard storyboard = new Storyboard();
            TimeSpan ts = new TimeSpan(0, 2, 0);
            double end = 200;//滚动距离，可根据数据源个数调整
            DoubleAnimation TopToButtomAnimation = new DoubleAnimation();
            TopToButtomAnimation.EasingFunction = new SineEase { EasingMode = EasingMode.EaseOut };
            TopToButtomAnimation.From = 0;
            TopToButtomAnimation.To = end;
            TopToButtomAnimation.Duration = new Duration(ts);
            TopToButtomAnimation.AutoReverse = true;
            TopToButtomAnimation.SpeedRatio = 1;
            storyboard.Duration = new Duration(TimeSpan.FromMinutes(4));
            storyboard.Children.Add(TopToButtomAnimation);
            Storyboard.SetTarget(TopToButtomAnimation, scrollViewer);
            Storyboard.SetTargetName(TopToButtomAnimation, scrollViewer.Name);
            Storyboard.SetTargetProperty(TopToButtomAnimation, new PropertyPath(ScrollViewerBehavior.VerticalOffsetProperty));
            storyboard.RepeatBehavior = RepeatBehavior.Forever;
            storyboard.Begin();

        }


        private static childItem FindVisualChild<childItem>(DependencyObject obj) where childItem : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                    return (childItem)child;
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        
    }

    public static class ScrollViewerBehavior
    {
        public static readonly DependencyProperty HorizontalOffsetProperty = DependencyProperty.RegisterAttached("HorizontalOffset", typeof(double), typeof(ScrollViewerBehavior), new UIPropertyMetadata(0.0, OnHorizontalOffsetChanged));
        public static void SetHorizontalOffset(FrameworkElement target, double value) => target.SetValue(HorizontalOffsetProperty, value);
        public static double GetHorizontalOffset(FrameworkElement target) => (double)target.GetValue(HorizontalOffsetProperty);
        private static void OnHorizontalOffsetChanged(DependencyObject target, DependencyPropertyChangedEventArgs e) => (target as ScrollViewer)?.ScrollToHorizontalOffset((double)e.NewValue);

        public static readonly DependencyProperty VerticalOffsetProperty = DependencyProperty.RegisterAttached("VerticalOffset", typeof(double), typeof(ScrollViewerBehavior), new UIPropertyMetadata(0.0, OnVerticalOffsetChanged));
        public static void SetVerticalOffset(FrameworkElement target, double value) => target.SetValue(VerticalOffsetProperty, value);
        public static double GetVerticalOffset(FrameworkElement target) => (double)target.GetValue(VerticalOffsetProperty);
        private static void OnVerticalOffsetChanged(DependencyObject target, DependencyPropertyChangedEventArgs e) => (target as ScrollViewer)?.ScrollToVerticalOffset((double)e.NewValue);
    }
}
