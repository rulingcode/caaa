using layer_0.cell;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface c_sync<T> : IEnumerable, INotifyCollectionChanged where T : m_sync
    {
        Task filter(Func<T, bool> filter);
        void close();
    }
}