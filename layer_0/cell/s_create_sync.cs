using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public delegate Task<T> s_create_sync<T>(string userid, string syncid);
}