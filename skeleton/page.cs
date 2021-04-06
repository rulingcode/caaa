using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public interface page
    {
        UIElement z_ui { get; }
        void focus();
        void start(api api);
    }
    public interface page<T> : page
    {
        Action<T> reply { get; set; }
    }
}
