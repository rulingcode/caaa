using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_app
{
    public partial class y_upsert_setup : y<y_upsert_setup.o>
    {
        public override string z_xid => all_command.x_app;
        public override string z_yid => nameof(y_upsert_setup);
        public string a_appid { get; set; }
        public e_degree a_degree { get; set; }
        public class o : o_base<error>
        { }
        public enum error
        {
            non,
            no_exist
        }
    }
}