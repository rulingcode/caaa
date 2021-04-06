using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public interface page2
    {
        UIElement z_ui { get; }
        void focus();
        void start(api2 api2);
    }
    public interface page2<T> : page2
    {
        Action<T> reply { get; set; }
    }
}
