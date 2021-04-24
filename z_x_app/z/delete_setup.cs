using layer_0.x_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_app.z
{
    class delete_setup : y_delete_setup
    {
        protected async override void implement()
        {
            await z_db.user<m.setup>(z_userid).delete(a_appid);
           
            reply(new o());
        }
    }
}
