using layer_0.x_app;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_app.z
{
    class upsert_app : y_upsert_app
    {
        protected async override void implement()
        {
            if (a_name?.Length < 5 || a_name.Length > 10)
            {
                reply(new o() { a_error = error.invalid_name });
                return;
            }
            m.app app = default;
            layer_0.cell.s_db<m.app> db = z_db.general_x<m.app>();
            if (a_appid == null)
            {
                app = new m.app()
                {
                    id = "app_" + ObjectId.GenerateNewId(),
                    owner = z_userid
                };
            }
            else
                app = await db.get(a_appid);

            if (app == null)
            {
                reply(new o() { a_error = error.invalid_appid });
                return;
            }
            if (app.owner != z_userid)
            {
                reply(new o() { z_error = layer_0.cell.e_error.invalid_permission });
                return;
            }
            if (app.name != a_name && await z_db.general_x<m.app>().any(i => i.name == a_name))
            {
                reply(new o() { a_error = error.duplicate_name });
                return;
            }
            app.name = a_name;
            app.app_text = a_text;
            await db.upsert(app);
            await a.update(z_userid, app.id);
        }
    }
}
