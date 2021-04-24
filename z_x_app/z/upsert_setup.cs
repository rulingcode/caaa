using layer_0.x_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_app.z
{
    class upsert_setup : y_upsert_setup
    {
        protected async override void implement()
        {
            if (await z_db.general_x<m.app>().any(i => i.id == a_appid))
            {
                reply(new o() { a_error = error.no_exist });
                return;
            }
            var db = z_db.user<m.setup>(z_userid);
            var setup = await db.get(z_userid);
            if (setup == null) setup = new m.setup()
            {
                id = a_appid
            };
            setup.degree = a_degree;
            await db.upsert(setup);
            await a.update(z_userid, a_appid);
            reply(new o());
        }
    }
}