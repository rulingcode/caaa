using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_file
{
    public class y_upsert_info : y<y_upsert_info.o>
    {
        public override string z_xid => all_command.x_file;
        public override string z_yid => nameof(y_upsert_info);
        public e_permission permission { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public class o : o_base<error>
        {
            public string id { get; set; }
        }
        public enum error
        {
            non,
            ownership,
            duplicate_name
        }
    }
}
