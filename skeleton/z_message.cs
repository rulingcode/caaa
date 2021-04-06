using skeleton.more_controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace skeleton
{
    public class z_message : page2<string>
    {
        message_box mb = new message_box() { Margin = new Thickness(20) };
        public e_type e { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string[] option { get; set; }
        ListBox lb => mb.lb;

        public Action<string> reply { get; set; }

        public UIElement z_ui => mb;

        public enum e_type
        {
            info,
            warning,
            error
        }
        public z_message()
        {
            lb.PreviewKeyDown += Lb_PreviewKeyDown;
        }
        private void Lb_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                reply(lb.SelectedValue as string);
        }
        public void focus()
        {
            lb.UpdateLayout();
            lb.SelectedIndex = 0;
            DependencyObject dependencyObject = lb.ItemContainerGenerator.ContainerFromIndex(lb.SelectedIndex);
            var lbi = dependencyObject as ListBoxItem;
            if (lbi == null)
                lb.Focus();
            else
                lbi.Focus();
        }
        public void start(api2 api2)
        {
            mb.txt_message.Text = text;
            if ((option?.Length ?? 0) == 0)
                option = new string[] { "متوجه شدم" };
            ObservableCollection<string> l = new ObservableCollection<string>(option);
            lb.ItemsSource = l;
            lb.SelectedIndex = 0;
        }
    }
}