using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3.c
{
    class sync_factory : c_sync_factory
    {
        List<sync> list = new();
        SemaphoreSlim locker = new(1, 1);
        public async Task<c_sync<T>> create<T>(string userid) where T : m_sync, new()
        {
            sync<T> rt = new sync<T>(userid);
            await locker.WaitAsync();
            list.Add(rt);
            locker.Release();
            return rt;
        }
        internal async Task delete(string xid, string userid, string[] deleted)
        {
            await locker.WaitAsync();
            var dv = list.Where(i => i.userid == userid && i.xid == xid).ToArray();
            locker.Release();
            foreach (var i in dv)
                i.delete(deleted);
        }
        internal async Task upsert(string xid, string userid, m_sync[] items)
        {
            await locker.WaitAsync();
            var dv = list.Where(i => i.userid == userid && i.xid == xid).ToArray();
            locker.Release();
            foreach (var item in dv)
                item.upsert(items);
        }
        internal async void close(sync val)
        {
            await locker.WaitAsync();
            list.Remove(val);
            locker.Release();
        }
    }
}