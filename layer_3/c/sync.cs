using layer_0.cell;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    abstract class sync
    {
        internal abstract string xid { get; }
        public abstract string userid { get; }
        internal abstract void upsert(IEnumerable<m_sync> val);
        internal abstract void delete(IEnumerable<string> deleted);
    }
    class sync<T> : sync, c_sync<T> where T : m_sync, new()
    {
        ObservableCollection<T> list = new ObservableCollection<T>();
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        Func<T, bool> func;
        internal sync(string userid)
        {
            this.userid = userid;
            T dv = new T();
            xid = dv.z_xid;
            list.CollectionChanged += List_CollectionChanged;
        }
        public override string userid { get; }
        internal override string xid { get; }
        public T selected { get; set; }
        private void List_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e) => CollectionChanged?.Invoke(this, e);
        public IEnumerator GetEnumerator() => list.GetEnumerator();
        public async Task filter(Func<T, bool> func)
        {
            this.func = func;
            var db = a.c_db.sync(xid, userid);
            var all = await db.all(i => func((T)i));
            foreach (var item in all)
            {
                var dv = list.FirstOrDefault(i => i.id == item.id);
                if (dv == null)
                    list.Add((T)item);
                else
                    dv.z_copy(item);
            }
        }
        internal override void upsert(IEnumerable<m_sync> val)
        {
            foreach (var i in val)
            {
                if (!func((T)i))
                    continue;
                var dv = list.FirstOrDefault(j => j.id == i.id);
                if (dv == null)
                    list.Add((T)i);
                else
                    dv.z_copy(i);
            }
        }
        internal override void delete(IEnumerable<string> ids)
        {
            foreach (var id in ids)
            {
                var dv = list.FirstOrDefault(i => i.id == id);
                if (dv != null)
                {
                    if (selected == dv)
                        selected = null;
                    list.Remove(dv);
                }
            }
        }
        public void close() => a.c_sync.close(this);
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => list.GetEnumerator();
        public int indexof(T val) => list.IndexOf(val);
    }
}