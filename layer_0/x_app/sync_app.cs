using layer_0.cell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_app
{
    public class sync_app : m_sync
    {
        public override e_permission z_permission => e_permission.u;
        public override string z_xid => all_command.x_app;
        public string name { get; set; }
        public string description { get; set; }
        public DateTime last_update { get; set; }
    }
}