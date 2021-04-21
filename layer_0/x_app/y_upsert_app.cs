using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_app
{
    public class y_upsert_app : y<y_upsert_app.o>
    {
        public override string z_xid => all_command.x_app;
        public override string z_yid => nameof(y_upsert_app);
        public override e_permission z_permission => e_permission.u;
        public string a_appid { get; set; }
        public e_app a_type { get; set; }
        public string a_name { get; set; }
        public string a_text { get; set; }
        public class o : o_base<error>
        {
            public string a_appid { get; set; }
        }
        public enum error
        {
            non,
            invalid_appid,
            duplicate_name,
            invalid_name
        }
    }
}
