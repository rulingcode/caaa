using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface c_sync_factory
    {
        Task<c_sync<T>> create<T>(string userid) where T : m_sync, new();
    }
}