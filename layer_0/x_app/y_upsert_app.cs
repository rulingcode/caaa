using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_app
{
    public class y_upsert_app : z_y<y_upsert_app.o>
    {
        public override string z_yid => nameof(y_upsert_app);
        public override e_permission z_permission => e_permission.u;
        public string appid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public class o : o_base<e_error> { }
        public enum error
        {
            non,
            invalid_appid,
            duplicate_name
        }
    }
}
