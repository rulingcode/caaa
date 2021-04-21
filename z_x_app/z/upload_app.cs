using layer_0.x_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_app.z
{
    class upload_app : y_uplad_app
    {
        protected async override void implement()
        {
            var db = z_db.general_x<m.app>();
            var app = await db.get(a_appid);
            if (app == null)
            {
                reply(new o() { a_error = error.no_exist });
                return;
            }
            if (app.owner != z_userid)
            {
                reply(new o() { z_error = layer_0.cell.e_error.invalid_permission });
                return;
            }
            await z_db.general_x<m.file>().upsert(new m.file()
            {
                id = a_appid,
                data = a_data
            });
            app.last_edit = DateTime.Now;
            await db.upsert(app);
            await a.update(z_userid, a_appid);
        }
    }
}