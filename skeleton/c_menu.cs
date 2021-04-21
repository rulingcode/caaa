using layer_0.cell;
using layer_0.x_app;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace skeleton
{
    //یا خدا و لعنت بر شیطان
    class c_menu
    {
        SemaphoreSlim locker = new(1, 1);
        List<c_sync<sync_app>> list = new List<c_sync<sync_app>>();
        c_sync<sync_app> selected_menu;
        public async void set_user(string userid)
        {
            if (selected_menu != null)
            {
                selected_menu.CollectionChanged -= Selected_CollectionChanged;
                selected_menu = null;
            }
            if (userid == null)
            {
                a.main_panel.set(new string[] { "انتخاب کاربر" }, 0);
                a.main_panel.show(a.user_selector);
                return;
            }
            await locker.WaitAsync();
            selected_menu = list.FirstOrDefault(i => i.userid == userid);
            if (selected_menu == null)
            {
                selected_menu = await a.api3.c_sync.create<sync_app>(userid);
                list.Add(selected_menu);
            }
            locker.Release();
            selected_menu.CollectionChanged += Selected_CollectionChanged;
            Selected_CollectionChanged(null, null);
        }
        private void Selected_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var apps = selected_menu.Select(i => i.name).ToArray();
            if (selected_menu.selected == null)
                selected_menu.selected = selected_menu.FirstOrDefault();
            a.main_panel.set(apps, selected_menu.indexof(selected_menu.selected));
        }
    }
}
